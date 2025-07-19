using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord;
using Accord.MachineLearning;
using Accord.Imaging;
using System.IO;
namespace ImageClusterizer
{
    public partial class Form1 : Form
    {
        private List<Bitmap> images = new List<Bitmap>();
        private List<string> imagePaths = new List<string>();
        private List<double[]> featureVectors = new List<double[]>();
        private int[] clusteredLabels;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImages_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Multiselect = true
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    images.Clear();
                    featureVectors.Clear();
                    imagePaths.Clear();

                    foreach (var file in ofd.FileNames)
                    {
                        Bitmap bmp = new Bitmap(file);
                        images.Add(bmp);
                        imagePaths.Add(file);

                        // Simple RGB mean as features
                        var stats = new ImageStatistics(bmp);
                        double[] features = new double[]
                        {
                            stats.Red.Mean,
                            stats.Green.Mean,
                            stats.Blue.Mean
                        };
                        featureVectors.Add(features);
                    }

                    MessageBox.Show($"{images.Count} images loaded.");
                }
            }
        }

        private void btnCluster_Click(object sender, EventArgs e)
        {
            if (images.Count == 0 || featureVectors.Count == 0)
            {
                MessageBox.Show("Please load the images first.");
                return;
            }

            int k = (int)numClusters.Value;

            var kmeans = new KMeans(k);
            var clusters = kmeans.Learn(featureVectors.ToArray());
            int[] labels = clusters.Decide(featureVectors.ToArray());
            clusteredLabels = labels;
            DisplayClusters(labels, k);
        }
        private void DisplayClusters(int[] labels, int k)
        {
            tabClusters.TabPages.Clear();

            // Create one tab per cluster
            for (int i = 0; i < k; i++)
            {
                TabPage tab = new TabPage($"Cluster {i + 1}");
                FlowLayoutPanel panel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true
                };
                tab.Controls.Add(panel);
                tabClusters.TabPages.Add(tab);
            }

            // Add images to corresponding cluster tab
            for (int i = 0; i < images.Count; i++)
            {
                int cluster = labels[i];
                PictureBox pb = new PictureBox
                {
                    Image = new Bitmap(images[i], new Size(100, 100)),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 100,
                    Height = 100,
                    Margin = new Padding(5)
                };

                var tab = tabClusters.TabPages[cluster];
                var panel = (FlowLayoutPanel)tab.Controls[0];
                panel.Controls.Add(pb);
            }
        }

        private void btnSaveClusters_Click(object sender, EventArgs e)
        {
            if (images.Count == 0 || clusteredLabels == null)
            {
                MessageBox.Show("You must cluster images before saving.");
                return;
            }

            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string basePath = folderDialog.SelectedPath;

                    for (int i = 0; i < clusteredLabels.Length; i++)
                    {
                        int cluster = clusteredLabels[i];
                        string clusterDir = Path.Combine(basePath, $"Cluster_{cluster + 1}");

                        if (!Directory.Exists(clusterDir))
                            Directory.CreateDirectory(clusterDir);

                        string originalName = Path.GetFileName(imagePaths[i]);
                        string savePath = Path.Combine(clusterDir, originalName);

                        images[i].Save(savePath);
                    }

                    MessageBox.Show("Images saved to clusters folders.");
                }
            }
        }
    }
}
