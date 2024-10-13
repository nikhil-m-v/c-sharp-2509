----Assignment 1: Sales Database
--CREATE TABLE Sales(SaleID int PRIMARY KEY IDENTITY, ProductID int, ProductName varchar(50),QuantitySold int,SaleAmount decimal(10,2),SaleDate date);
--INSERT INTO Sales(ProductID, ProductName,QuantitySold,SaleAmount,SaleDate) VALUES (101,'Laptop',5,5000,'2024-09-01'),(102,'Mouse',10,250,'2024-09-02'),(101,'Laptop',3,3000,'2024-09-03'),(103,'Keyboard',6,150,'2024-09-04'),(102,'Mouse',6,150,'2024-09-05');
--SELECT SUM(SaleAmount) as TotalSalesAmount from Sales;
--SELECT MAX(QuantitySold) as MaxQuantitySold from Sales;
--SELECT AVG(SaleAmount) as AvgSalesAmount from Sales;
--SELECT MIN(QuantitySold) as MinQuantitySold from Sales;
--SELECT SUM(SaleAmount) as TotalSalesAmount from Sales WHERE ProductName='Laptop';

----Assignment 2: Employee Salaries
--INSERT INTO Employees (FirstName, LastName, Department, Salary,Hiredate) 
--VALUES ('John', 'Doe', 'IT', 5000,'2022-01-10');

--INSERT INTO Employees (FirstName, LastName, Department, Salary,Hiredate) 
--VALUES ('Jane', 'Smith', 'HR', 6000,'2021-03-15');

--INSERT INTO Employees (FirstName, LastName, Department, Salary,Hiredate) 
--VALUES ('Bob', 'Johnson', 'Finance', 5500,'2020-06-20');

--INSERT INTO Employees (FirstName, LastName, Department, Salary,Hiredate) 
--VALUES ('Alice', 'Brown', 'IT', 6200,'2023-02-01');

--INSERT INTO Employees (FirstName, LastName, Department, Salary,Hiredate) 
--VALUES ('Charlie', 'White', 'Marketing', 4800,'2023-03-10');

--SELECT SUM(Salary) as totalsalaryexpenditure FROM Employees

--SELECT MAX(Salary) as highestsalary FROM Employees

--SELECT AVG(Salary) as averagesalary FROM Employees

--SELECT MIN(Salary) as minimumsalary FROM Employees WHERE Department='IT';

--SELECT Department,COUNT(EmployeeID) as totalnumberofemployees from Employees GROUP BY Department;

----Assignment 3: Inventory Management
--CREATE TABLE Inventory(ProductID int PRIMARY KEY IDENTITY(201,1), ProductName varchar(50),QuantityInStock int,ReorderAmount int,LastRestockDate date);
--INSERT INTO Inventory(ProductName,QuantityInStock,ReorderAmount,LastRestockDate) VALUES ('Monitor',50,10,'2024-08-25'),('Printer',30,5,'2024-09-01'),('Mouse',100,15,'2024-09-10'),('Keyboard',80,20,'2024-09-15'),('Laptop',25,5,'2024-09-20');
--SELECT SUM(QuantityInStock) AS TotalQuantityInStock from Inventory;
--SELECT MAX(QuantityInStock) AS HighestQuantityInStock from Inventory;
--SELECT AVG(ReorderAmount) AS AVGReorderLevel from Inventory;
--SELECT SUM(QuantityInStock) AS TotalQuantityInStock from Inventory  WHERE QuantityInStock>ReorderAmount;

----Assignment 4: Customer Orders Database
--CREATE TABLE CustomerOrders(OrderID int PRIMARY KEY IDENTITY(501,1),CustomerID VARCHAR(50), OrderDate DATE,OrderAmount INT,QuantityOrdered INT);
--INSERT INTO CustomerOrders(CustomerID, OrderDate,OrderAmount,QuantityOrdered) VALUES ('C001','2024-09-10',1500,3),('C002','2024-09-11',2000,5),('C001','2024-09-12',1000,2),('C003','2024-09-13',2500,4),('C002','2024-09-14',3000,6);
--SELECT SUM(OrderAmount) AS TotalOrderAmount from CustomerOrders;
--SELECT AVG(OrderAmount) AS AVGOrderAmount from CustomerOrders;
--SELECT MAX(OrderAmount) AS MAXOrderAmount from CustomerOrders;
--SELECT SUM(QuantityOrdered) AS TotalQuantityOrdered from CustomerOrders;
--SELECT MIN(OrderAmount) AS MINOrderAmount from CustomerOrders;

----Assignment 6: Product Ratings Database
--CREATE TABLE ProductRatings(RatingID int PRIMARY KEY IDENTITY,ProductID VARCHAR(50),CustomerID VARCHAR(50), Rating INT,ReviewDate DATE);
--INSERT INTO ProductRatings (ProductID, CustomerID, Rating, ReviewDate) VALUES ('P001', 'C001', 4, '2024-09-01'),('P002', 'C002', 5, '2024-09-02'),('P001', 'C003', 3, '2024-09-03'),('P003', 'C001', 2, '2024-09-04'),('P002', 'C004', 4, '2024-09-05');
--SELECT ProductID,AVG(Rating) as AVGRating from ProductRatings GROUP BY ProductID
--SELECT MAX(Rating) as MAXRating from ProductRatings
--SELECT MIN(Rating) as MINRating from ProductRatings
--SELECT ProductID,COUNT(Rating) as COUNTRating from ProductRatings GROUP BY ProductID
--SELECT COUNT(DISTINCT ProductID) from ProductRatings

----Assignment 1:
----Retrieve Employees Who Work in Specific Departments Using IN Operator

--SELECT FirstName,Department FROM Employees	WHERE Department='HR' OR Department='Finance' OR Department='IT';

----Assignment 2:
----Retrieve Products Within a Specific Price Range Using BETWEEN Operator

--SELECT ProductName,Price FROM Products WHERE Price BETWEEN 100 AND 500;

----------3---------------
---Retrieve the customer names that start with the letter 'A'.

--select * from Customers where CustomerName like 'A%'

----------4------------------------
----Retrieve the order IDs of orders placed on '2023-01-01', '2023-02-01', and '2023-03-01'.

--create table Orderin(
--OrderID int,
--OrderDate date,
--);

--insert into Orderin (OrderID,OrderDate)
--values
--(1,'2023-02-03'),
--(2,'2023-01-01'),
--(3,'2023-03-01')


--select OrderID from Orderin where OrderDate in ('2023-01-01', '2023-02-01',  '2023-03-01')

-----------5---------------
--Retrieve the product names and prices of products that are not priced between 100 and500.

--select*from Products where Price not between 100 and 500


-----------6---------------
--Retrieve the order IDs where the total amount is either greater than 5000 or less than 1000.

--select OrderID from CustomerOrders where OrderAmount>5000 or OrderAmount<1000

---------7-----------
----Retrieve the names of employees who do not work in the 'HR' or 'IT' departments.

--select FirstName,LastName from Employees where Department not in ('HR','IT')

---------8----------
----Retrieve the order IDs of orders placed between '2023-01-01' and '2023-12-31'.

--select OrderID from Orderin where OrderDate between '2023-01-01' and '2023-12-31'

---------9----------
----Retrieve the customer names that do not have 'John' in them.

--select CustomerName from Customers where CustomerName not like '%John%'

--------10---------
----Retrieve the product names and prices of products that are either in category 'A' or have a price less than 100.

--CREATE TABLE Categories (
--CategoryID INT PRIMARY KEY,
--CategoryName VARCHAR(50) NOT NULL
--);

--insert into Categories
--values(1, 'A'),
--(2,'B')

--Alter table Products
--add CategoryID int

--update Products
--set CategoryID = 2 where ProductName='Printer'


 --select ProductName, Price from Products where Price<100 or CategoryID = (select CategoryID from Categories where CategoryName='A')


