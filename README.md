K-Means Clustering
K-means algorithm is an iterative algorithm that tries to partition the dataset into Kpre-defined distinct non-overlapping subgroups (clusters) where each data point belongs to only one group.
It tries to make the inter-cluster data points as similar as possible while also keeping the clusters as different (far) as possible.
It assigns data points to a cluster such that the sum of the squared distance between the data points and the cluster’s centroid (arithmetic mean of all the data points that belong to that cluster) is at the minimum.
The less variation we have within clusters, the more homogeneous (similar) the data points are within the same cluster. The approach k-means follows to solve the problem is called Expectation-Maximization.
The E-step is assigning the data points to the closest cluster. The M-step is computing the centroid of each cluster. Hence each cluster has datapoints with some commonalities, and it is away from other clusters.






<img width="437" height="622" alt="image" src="https://github.com/user-attachments/assets/2b0783de-982f-4fd0-81cb-3c718fffd6cf" />

k-means clustering algorithm fluchat


below diagram explains the working of the K-means Clustering Algorithm:

<img width="753" height="380" alt="image" src="https://github.com/user-attachments/assets/94aa046b-4323-4fef-8abd-f96235fb8d1a" />

How dose k-means clustering work

An example of K-means is illustrated with considering the visual plots:

Suppose we have two variables M1 and M2. The x-y axis scatter plot of these two variables is given below image.
Let's take number k of clusters, i.e., K=2, to identify the dataset and to put them into different clusters.
It means here we will try to group these datasets into two different clusters Figure (a). 
We need to choose some random k points or centroid to form the cluster. These points can be either the points from the dataset or any other point.
So, here we are selecting the below two points as k points, which are not the part of our dataset. Consider the below image Figure (b).


<img width="251" height="191" alt="image" src="https://github.com/user-attachments/assets/4817f99d-9b60-4aca-9148-9c82bc4d8c01" />

Figure (a)

<img width="226" height="198" alt="image" src="https://github.com/user-attachments/assets/8797f25f-823f-493e-9c2b-b74145c388f1" />

Figure (b)

Now we will assign each data point of the scatter plot to its closest K-point or centroid.
We will compute it by applying some mathematics that we have studied to calculate the distance between two points.
So, we will draw a median between both the centroids. Consider the below image Figure (a).
From the above image, it is clear that points left side of the line is near to the K1 or blue centroid, and points to the right of the line are close to the yellow centroid.
Let's color them as blue and yellow for clear visualization Figure (b).



<img width="243" height="229" alt="image" src="https://github.com/user-attachments/assets/a45c6efb-b478-4a79-9f04-a3f392fc5ce9" />

Figure (a)


<img width="229" height="228" alt="image" src="https://github.com/user-attachments/assets/21b6ec77-36d2-4423-aded-1fd83c8d419b" />

Figure (b)


As we need to find the closest cluster, so we will repeat the process by choosing a new centroid.
To choose the new centroids, we will compute the center of gravity of these centroids, and will find new centroids as below Figure (a).
Next, we will reassign each datapoint to the new centroid. For this, we will repeat the same process of finding a median line. The median will be like below Figure (b).


<img width="254" height="251" alt="image" src="https://github.com/user-attachments/assets/37842cf1-b69a-4ebc-a16c-e8c7939e3e2b" />

Figure (a)	

<img width="269" height="263" alt="image" src="https://github.com/user-attachments/assets/b3ab5277-88e9-4d16-9e9b-8d3e717bfedd" />

Figure (b)

From the above image, we can see, one yellow point is on the left side of the line, and two blue points are right to the line.
So, these three points will be assigned to new centroids Figure (a). As reassignment has taken place, we will again go to the step-4, which is finding new centroids or K-points.
We will repeat the process by finding the center of gravity of centroids, so the new centroids will be as shown in the below Figure (b).


<img width="277" height="269" alt="image" src="https://github.com/user-attachments/assets/ce0c52da-cd4b-4012-8030-8885ff52b3e0" />

Figure (a)

<img width="281" height="280" alt="image" src="https://github.com/user-attachments/assets/fe04d01c-ba39-4a64-8048-e2acc055097c" />

Figure (b)

As we got the new centroids again will draw the median line and reassign the data points. So, the image will be Figure (a).
We can see in the above image; there are no dissimilar data points on either side of the line, which means our model is formed. Consider the below image Figure (b).


<img width="307" height="285" alt="image" src="https://github.com/user-attachments/assets/9d0276e7-5a74-43db-b716-b438d502c4d1" />

Figure (a)

<img width="322" height="278" alt="image" src="https://github.com/user-attachments/assets/3019166d-9619-4fbd-acd1-1abc4443d347" />

Figure (b)

As our model is ready, so we can now remove the assumed centroids, and the two final clusters will be as shown in the below Figure.


<img width="450" height="387" alt="image" src="https://github.com/user-attachments/assets/3e317e1f-7f0f-43d6-8fd8-fb2dc99b5865" />


Now lets explain how dose the Systeam work:


<img width="965" height="653" alt="image" src="https://github.com/user-attachments/assets/0a6673e5-4d9e-4df9-9a02-ec4a773e58f3" />

Project Interfase

Step one/ upliad datas:
click on upload images Button to upload the data.

<img width="1075" height="648" alt="image" src="https://github.com/user-attachments/assets/5e83a6d1-6f84-43b7-b7b0-faf82ef68fe8" />


When you upload the data it show to you the number of images you uploaded it in message box.
<img width="957" height="645" alt="image" src="https://github.com/user-attachments/assets/c7079067-02d6-4a4e-9815-38ce75751437" />

Step two/ chose the number of cluster and click cluster Images to start the algorithm.

<img width="479" height="53" alt="image" src="https://github.com/user-attachments/assets/6e3dae63-ffaa-4e17-9fcb-cfefa61059b3" />


When you click on Cluster Images Button the algorithm start clustering images to groups According to the dominant color in the Images.

<img width="965" height="649" alt="image" src="https://github.com/user-attachments/assets/c4699bd5-f406-4c2c-b9ea-1cc0fec0f19d" />

CLUSTER 1

<img width="960" height="645" alt="image" src="https://github.com/user-attachments/assets/cf26e8c7-ff3d-4ad7-85a8-449bdf648c82" />

CLUSTER 2

<img width="962" height="646" alt="image" src="https://github.com/user-attachments/assets/aeb887cf-d7d0-480e-af41-94b939940782" />

CLUSTER 3

<img width="960" height="647" alt="image" src="https://github.com/user-attachments/assets/209ba7d4-3cfc-4484-a1f5-17ae81df8d76" />

CLUSTER 4


Step three/ saving the Clusters in the computer:
click on Save Clusters the select the location you need to save all Clusters on it and click save.

<img width="956" height="644" alt="image" src="https://github.com/user-attachments/assets/6e05b64e-f57b-43f9-930d-e1db82062584" />


<img width="960" height="642" alt="image" src="https://github.com/user-attachments/assets/3a58e5b6-8e14-44f5-b2eb-e6a1a38418fc" />


<img width="1025" height="593" alt="image" src="https://github.com/user-attachments/assets/bfde4e0e-6500-426c-9b76-d7646b70bf8d" />


<img width="1045" height="817" alt="image" src="https://github.com/user-attachments/assets/8d94eada-8a21-4e7c-bb12-084a315a08ba" />



