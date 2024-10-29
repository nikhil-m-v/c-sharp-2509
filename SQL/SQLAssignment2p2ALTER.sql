----Assignment 1: Add a New Column 
----Task: Add a column DateOfBirth (data type DATE) to the Employees table to store employees' 
----dates of birth. 

--ALTER TABLE Employees 
--ADD DateOfBirth DATE; 

--SELECT * FROM Employees

----Assignment 2: Modify Column Data Type 
----Task: Change the data type of the PhoneNumber column in the Customers table to 
----VARCHAR(15).

--ALTER TABLE Customers 
--ALTER COLUMN PhoneNumber VARCHAR(15); 

----Assignment 3: Add a Primary Key 
----Task: Add a primary key to the DepartmentID column in the Departments table. 

--CREATE TABLE Departments(DepartmentID int IDENTITY,DepartmentName varchar(20));

--SELECT * FROM Departments;

--ALTER TABLE Departments 
--ADD CONSTRAINT PK_Departments PRIMARY KEY (DepartmentID); 

----Assignment 4: Drop a Column 
----Task: Remove the MiddleName column from the Employees table. 

--ALTER TABLE Employees 
--ADD MiddleName varchar(50); 

--SELECT * FROM Employees

--ALTER TABLE Employees 
--DROP COLUMN MiddleName;

----Assignment 5: Add a Foreign Key 
----Task: Add a foreign key to the EmployeeID column in the Orders table that references the 
----EmployeeID column in the Employees table. 

--SELECT * FROM ORDERS;

--ALTER TABLE ORDERS 
--ADD CONSTRAINT FK_Customers_ORDERS  
--FOREIGN KEY (CustomerID)  
--REFERENCES Customers(CustomerID); 

----Assignment 6: Drop a Foreign Key 
----Task: Remove the foreign key constraint that references EmployeeID from the Orders table. 

--ALTER TABLE ORDERS 
--DROP CONSTRAINT FK_Customers_ORDERS; 

----Assignment 7: Rename a Column 
----Task: Rename the column FullName to EmployeeFullName in the Employees table. 

--EXEC sp_rename 'Employees.FirstName', 'EmployeeFirstName', 'COLUMN'; 

----Assignment 8: Add a Default Value 
----Task: Add a default value of 'Active' to the Status column in the Employees table.

--ALTER TABLE Employees 
--ADD Status VARCHAR(10);

--select * from Employees

--ALTER TABLE Employees
--ADD CONSTRAINT df_Status
--DEFAULT 'Active' FOR Status;

----Assignment 9: Drop a Primary Key 
----Task: Drop the primary key constraint from the Departments table. 

--ALTER TABLE Departments 
--DROP CONSTRAINT PK_Departments; 


----Assignment 10: Add a Unique Constraint 
----Task: Ensure the Email column in the Employees table is unique by adding a unique constraint. 

--ALTER TABLE Employee 
--ADD email varchar(50) NOT NULL;

--select * from Employee

--ALTER TABLE Employee 
--ADD CONSTRAINT UQ_Email UNIQUE (Email);

----Assignment 11: Add a Check Constraint 
----Task: Add a check constraint to the Salary column in the Employees table to ensure that no 
----salary is less than 1000. 

--ALTER TABLE Employees 
--ADD CONSTRAINT Ch_Salary CHECK (Salary>1000); 

--SELECT * FROM Employees;

--INSERT INTO Employees (EmployeeFirstName, LastName, Department, Salary,DateOfBirth,Status) 
--VALUES ('John', 'Doe', 'HR', 500,'2001-05-04','Active');

----Assignment 13: Drop a Check Constraint 
----Task: Remove the check constraint from the Salary column in the Employees table. 

--ALTER TABLE Employees 
--DROP CONSTRAINT Ch_Salary; 

