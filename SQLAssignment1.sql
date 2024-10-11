----ASSIGNMENT 1
--create database CompanyDB;

--use CompanyDB;

--create table Employees(EmployeeId int PRIMARY KEY IDENTITY, FirstName varchar(50), LastName varchar(50), Department varchar(50),Salary Decimal(10,2));

----ASSIGNMENT 2
--INSERT INTO Employees (FirstName, LastName, Department, Salary) 
--VALUES ('John', 'Doe', 'HR', 50000);

--INSERT INTO Employees (FirstName, LastName, Department, Salary) 
--VALUES ('Jane', 'Smith', 'IT', 60000);

--INSERT INTO Employees (FirstName, LastName, Department, Salary) 
--VALUES ('David', 'Lee', 'Marketing', 55000);

----ASSIGNMENT 3
--select * from Employees;

--select FirstName,LastName,salary from Employees WHERE Department = 'IT' and salary>50000;

--select max(salary) as MaxSalary from employees;

----ASSIGNMENT 4
--UPDATE Employees set salary=55000 WHERE FirstName = 'John';
--UPDATE Employees set department='Marketing' WHERE FirstName='Jane';

----ASSIGNMENT 5
--DELETE FROM Employees where FirstName='David';
--DELETE FROM Employees where Department='Marketing';

----ASSIGNMENT 6
--CREATE TABLE Products(ProductID int PRIMARY KEY IDENTITY, ProductName varchar(50), Category varchar(50), Price decimal(10,2),Stock int);
--INSERT INTO Products(ProductName,Category,Price,Stock) VALUES('Laptop','Electronics',1000,50),('Mouse','Electronics',20,200),('Keyboard','Electronics',30,150),('Laptop','Electronics',150,75);
--select * from Products;
--select * from Products ORDER BY price DESC;
--update Products set price=25 where ProductName='Mouse';
--delete from Products where ProductID = '2';
--select * from Products ORDER BY ProductName ASC;

----ASSIGNMENT 7
--CREATE TABLE Books(BookID int PRIMARY KEY IDENTITY, Title varchar(50),Author varchar(50), PublishedYear int, AvailableCopies int);
--INSERT INTO Books(Title,Author,PublishedYear,AvailableCopies) values ('The Great Gatsby','F. Scott Fitzgerald',1925,3),('1984','George Orwell ',1949,2),('To Kill a Mockingbird','Harper Lee',1960 ,5),('Brave New World','Aldous Huxley ',1932,4);
--UPDATE Books SET AvailableCopies=5 where Title='1984';
--DELETE FROM Books where BookID=1;
--SELECT * FROM Books where PublishedYear>1950;

----ASSIGNMENT 8
--CREATE TABLE Customers(CustomerID int PRIMARY KEY, CustomerName varchar(50),Email varchar(50), PhoneNumber varchar(20));
--INSERT INTO Customers(CustomerID, CustomerName,Email, PhoneNumber) VALUES (201,'Alice Johnson','alice@example.com','555-1234 '),(202,'Bob Smith','bob@example.com','555-5678'),(203,'Charlie Brown','charlie@example.com','555-8765');
--INSERT INTO Customers(CustomerID, CustomerName,Email, PhoneNumber) VALUES (204,'David Wilson','david@example.com','555-4321')
--UPDATE Customers set PhoneNumber='555-9999' where CustomerName='Alice Johnson';
--DELETE FROM Customers where CustomerID=202;

----ASSIGNMENT 9
--CREATE TABLE Orders(OrderID int PRIMARY KEY IDENTITY(301,1), CustomerID int, OrderDate DATE,TotalAmount DECIMAL(10,2))
--INSERT INTO Orders(CustomerID, OrderDate,TotalAmount) VALUES (201,'2024-09-01', 250.00),(202,'2024-09-02', 150.00),(203,'2024-09-03', 200.00);
--INSERT INTO Orders(CustomerID, OrderDate,TotalAmount) VALUES (204,'2024-09-04', 300.00)
--UPDATE Orders set TotalAmount=275.00 where OrderID=301;
--DELETE FROM Orders where OrderId=302;
--SELECT * FROM Orders where TotalAmount>200;
--SELECT OrderID,TotalAmount FROM Orders;

----ASSIGNMENT 10
--CREATE TABLE Students(StudentID int PRIMARY KEY IDENTITY, FirstName varchar(50),LastName varchar(50),Email varchar(50));
--INSERT INTO Students(FirstName,LastName,Email) VALUES('John', 'Doe', 'john.doe@example.com'),('Jane', 'Smith', 'jane.smith@example.com'),('Mike', 'Johnson', 'mike.johnson@example.com');

----ASSIGNMENT 11
--CREATE TABLE Courses(CourseID int PRIMARY KEY IDENTITY, CourseName varchar(50))
--INSERT INTO Courses(CourseName) VALUES ('Python'),('Java'),('MySQL')

--CREATE TABLE Enrollments(EnrollmentID int PRIMARY KEY IDENTITY, StudentID int,CourseID int, FOREIGN KEY(StudentID) REFERENCES Students(StudentID),FOREIGN KEY(CourseID) REFERENCES Courses(CourseID))
--INSERT INTO Enrollments(StudentID,CourseID) values (1,1),(1,2),(2,3);

----ASSIGNMENT 12
 --CREATE TABLE OrderDetails( OrderID INT PRIMARY KEY, ProductID INT UNIQUE, Quantity INT)

 ----ASSIGNMENT 13
 --CREATE TABLE Users( UserID INT PRIMARY KEY, Email varchar(50) UNIQUE, Username varchar(50) UNIQUE)

 ----ASSIGNMENT 14
 --CREATE TABLE Product (AutoID INT PRIMARY KEY IDENTITY(1,1),ProductName VARCHAR(100),Price DECIMAL(10, 2));

 ----ASSIGNMENT 15
 --CREATE TABLE Employee (SSN VARCHAR(9) PRIMARY KEY,FirstName VARCHAR(50),LastName VARCHAR(50),Position VARCHAR(50));

 ----ASSIGNMENT 16
 --CREATE TABLE Customer (CustomerID INT PRIMARY KEY,PhoneNumber VARCHAR(15) UNIQUE,FirstName NVARCHAR(50),LastName NVARCHAR(50));

 ----ASSIGNMENT 17
--create view employeeview as select FirstName,LastName,Department from Employees;
--select * from employeeview;

----ASSIGNMENT 18
--create view EditableEmployeeView as select EmployeeID,FirstName,LastName,Salary from Employees;
--update EditableEmployeeView set salary=50000 where EmployeeID=1;
--select * from EditableEmployeeView;

----ASSIGNMENT 19
--create view EmployeeSalaryBonusView AS select FirstName,LastName,Salary,Salary*0.1 AS Bonus from Employees;
--select * from EmployeeSalaryBonusView;

----ASSIGNMENT 20
--ALTER VIEW employeeview AS SELECT Salary from Employees;
--select * from employeeview;

----ASSIGNMENT 21
--create view FilteredEmployeeView as select EmployeeID,FirstName,LastName,Department from Employees;
--select * from FilteredEmployeeView where Department='HR';

----ASSIGNMENT 22
--DROP VIEW employeeview;
--select * from employeeview;

