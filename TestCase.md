#### Smoke Test
1. Navigate to URL "http://computer-database.gatling.io/computers" and verify contents 
-	Verify Computers List is displayed and visible
-	Verify Computers Count is displayed
-	Verify Filters is visible and enabled
-	Verify Add New Computer buttons visible and enabled
-	Verify the All columns are visible
	-	Verify the Computer Name columns are visible
	-	Verify the Introduced Name columns are s visible
	-	Verify the Discontinue Name columns are visible
	-	Verify the Company Name columns are visible
-	Verify List is sorted alphabetical
-	Verify Page number is displayed 
-	Verify Back and Next buttons are displayed



2. Verify Filters by Name
-		Prerequisite: Navigate to URL
- Enter an existing name "Apple IIGS"
	-	Verify only related results are displayed
- Enter a non-existing name "Weight Lifters"
 	- Verify no results are displayed
- Enter an existing name "AC" for multi-page results
	- Verify results are displayed in multi pages


3. Verify Add Computers
-			Prerequisite: Navigate to URL
-	Click on "Add a new Computer"
	-	New page is displayed prompting for details
- Enter Valid Computer Name
 	- Enter "Random Computer" Name
 - Enter a valid date for Induction date
   - Entered a random valid past date 
 - Enter a valid date for Discontinue
   - Entered a date as today
  - Select company
  	-	Select company "ACVS" from List
- Click on Save Button
 - Successful Message is displayed
-Enter “Computer Name” in filters and Click
 - List of computes are displayed along with newly created computer

#### Regression Test
1.	Verify sorting columns by “Computer Name” 
2.	Verify sorting columns by “Introduced” 
3.	Verify sorting columns by “Discontinued”
4.	Verify sorting columns by “Company”
5.	View existing computer details
6.	Update computer mandatory fields and verify warning message
7.	Update computer details and save
8.	Update computer details and cancel
9.	Update computer details and click on back button
10.	Update computer details and do page refresh
11.	Update computer details and click on “Computer database” 
12.	Update computer details with invalid date format and save
13.	Update computer details and remove few fields
14.	Update computer details with Discontinued before Introduced Date
15.	Update computer details with same dates
16.	Delete existing computer 
17.	Delete and create same computer
18.	Create computer details and save
19.	Create computer details and cancel
20.	Create computer details and click on back button
21.	Create computer details and do page refresh
22.	Create computer details and click on “Computer database” 
23.	Create computer details with invalid date format and save
24.	Create computer details and remove few fields
25.	Create computer mandatory fields and verify warning message
26.	Create computer details with an existing item
27.	Update the URL with page number
28.	Update the URL with Item count to 50-100
29.	Update the URL with Item count to 574
30.	Clear filter by clicking on Computer Database Hyperlink
31.	Verify Page number updated correctly when navigating
32.	Verify Add computer name for Length with Max Char
33.	Verify Add Computer Name for Special Char


Bugs:
1.	Newly added computers are not visible
2.	Update computers are not reflected



		
		
