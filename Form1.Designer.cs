namespace ImageClusterizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadImages = new System.Windows.Forms.Button();
            this.btnCluster = new System.Windows.Forms.Button();
            this.btnSaveClusters = new System.Windows.Forms.Button();
            this.numClusters = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabClusters = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).BeginInit();
            this.tabClusters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadImages
            // 
            this.btnLoadImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLoadImages.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImages.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadImages.Location = new System.Drawing.Point(12, 12);
            this.btnLoadImages.Name = "btnLoadImages";
            this.btnLoadImages.Size = new System.Drawing.Size(162, 32);
            this.btnLoadImages.TabIndex = 0;
            this.btnLoadImages.Text = "UpLoad Images";
            this.btnLoadImages.UseVisualStyleBackColor = false;
            this.btnLoadImages.Click += new System.EventHandler(this.btnLoadImages_Click);
            // 
            // btnCluster
            // 
            this.btnCluster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCluster.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCluster.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCluster.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCluster.Location = new System.Drawing.Point(12, 50);
            this.btnCluster.Name = "btnCluster";
            this.btnCluster.Size = new System.Drawing.Size(162, 31);
            this.btnCluster.TabIndex = 1;
            this.btnCluster.Text = "Cluster Images";
            this.btnCluster.UseVisualStyleBackColor = false;
            this.btnCluster.Click += new System.EventHandler(this.btnCluster_Click);
            // 
            // btnSaveClusters
            // 
            this.btnSaveClusters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSaveClusters.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClusters.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveClusters.Location = new System.Drawing.Point(12, 87);
            this.btnSaveClusters.Name = "btnSaveClusters";
            this.btnSaveClusters.Size = new System.Drawing.Size(162, 30);
            this.btnSaveClusters.TabIndex = 2;
            this.btnSaveClusters.Text = "Save Clusters";
            this.btnSaveClusters.UseVisualStyleBackColor = false;
            this.btnSaveClusters.Click += new System.EventHandler(this.btnSaveClusters_Click);
            // 
            // numClusters
            // 
            this.numClusters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numClusters.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numClusters.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numClusters.Location = new System.Drawing.Point(528, 16);
            this.numClusters.Name = "numClusters";
            this.numClusters.Size = new System.Drawing.Size(120, 27);
            this.numClusters.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(232, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chose The Number Of Clusters";
            // 
            // tabClusters
            // 
            this.tabClusters.Controls.Add(this.tabPage1);
            this.tabClusters.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClusters.Location = new System.Drawing.Point(12, 142);
            this.tabClusters.Name = "tabClusters";
            this.tabClusters.SelectedIndex = 0;
            this.tabClusters.Size = new System.Drawing.Size(936, 463);
            this.tabClusters.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(928, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(960, 617);
            this.Controls.Add(this.tabClusters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numClusters);
            this.Controls.Add(this.btnSaveClusters);
            this.Controls.Add(this.btnCluster);
            this.Controls.Add(this.btnLoadImages);
            this.Name = "Form1";
            this.Text = " ImageClusterizer";
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).EndInit();
            this.tabClusters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImages;
        private System.Windows.Forms.Button btnCluster;
        private System.Windows.Forms.Button btnSaveClusters;
        private System.Windows.Forms.NumericUpDown numClusters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabClusters;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

