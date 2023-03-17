# K-Means_Cluster_Solver
 
 ![Solver4](https://user-images.githubusercontent.com/37045243/225842099-a3482b00-309d-4e92-94d8-f5f410741be8.png)


---

### Table of Contents
#### 1. Assumptions
#### 2. Features
#### 3. Program Flow
---
#### 1. Assumptions
+ Only 2 Centroids are used
+ If no Centroid 1 was added/selected data point 1 will be assumed as C1
+ If no Centroid 2 was added/selected data point 2 will be assumed as C2

---
#### 2. Features
#### **_Input_**

>+  The User enters the X-Coordinate
>+  The User enters the Y-Coordinate
>+  The User then selects Centroid 1 Or 2 if applicable
>+  When the User has enetered 2 or more data points the 'Solve' Button is enabled
>+  The User can click on the Reset Button to start over

#### **_Output_**

>+ Each Iteration will be shown along with Centroids used in Iteration
>+ Final Result will show Centroid 1's & 2's coordinates

---
#### 3. Program Flow

![KMeansWalkthrough](https://user-images.githubusercontent.com/37045243/225843531-57b3278a-4f68-446d-a8e0-f86e5f04c073.gif)

1. The User enters the X-Coordinate
2. The User enters the Y-Coordinate
3. The User then selects Centroid 1 Or 2 if applicable
4. Press 'Add Data Point'
5. Repeat 1-4 until at least 2 data points have been added
6. Continue with 1-4 if more points need to be added, else press 'Solve'
5. View Output
6. Press 'Reset'
