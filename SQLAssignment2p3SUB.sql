--Assignment 1:  
--Retrieve Employees Who Earn More Than the Average Salary 
--Task: Retrieve the names and salaries of employees whose salary is greater than the average 
--salary of all employees in the company. 

SELECT EmployeeFirstName,Salary FROM Employees WHERE Salary>(SELECT AVG(Salary) FROM Employees);

--Assignment 2:  
--Find Departments with More Than 5 Employees 
--Task: Retrieve the department names that have more than 5 employees.

SELECT EmployeeFirstName,DepartmentID FROM Employees;
SELECT DepartmentName FROM Departments WHERE DepartmentID IN (SELECT DepartmentID FROM Employees GROUP BY DepartmentID HAVING COUNT (EmployeeID) > 3);

--Assignment 3:  
--Retrieve Products with a Price Higher Than the Maximum Price of Category 'A' 
--Task: Retrieve the product names and prices of products that have a price higher than the 
--maximum price of products in category 'A'. 

SELECT ProductName,Price from Products WHERE Price > (SELECT MAX(Price) FROM Products WHERE CategoryID='A')

--Assignment 4:  
--Retrieve Employees Who Work in Departments with Average Salary Higher Than 50,000 
--Task: Retrieve the names of employees who work in departments where the average salary is 
--higher than 50,000.

select * from Employees;
select * from Departments;


ALTER TABLE Employees ADD DepartmentID INT CONSTRAINT FK_Employees_Department 
FOREIGN KEY (DepartmentID)  
REFERENCES Departments(DepartmentID);

SELECT EmployeeFirstName, DepartmentID
FROM Employees
WHERE DepartmentID IN (
    SELECT DepartmentID
    FROM Employees
    GROUP BY DepartmentID
    HAVING AVG(Salary) > 5000
);

--Assignment 5:  
--Find Employees Who Earn More Than Their Department's Average Salary 
--Task: Retrieve the names of employees who earn more than the average salary of their 
--department. 


SELECT EmployeeFirstName, DepartmentID, Salary
FROM Employees AS e
WHERE Salary > (
    SELECT AVG(Salary)
    FROM Employees
    WHERE DepartmentID = e.DepartmentID
);

--Assignment 6:  
--Find Customers Who Have Not Placed Any Orders 
--Task: Retrieve the names of customers who have not placed any orders. 

SELECT * FROM Orders
SELECT * FROM Customers


SELECT CustomerName
FROM Customers
WHERE CustomerID NOT IN (SELECT CustomerID FROM Orders)


--Assignment 8:  
--Find Products That Have Never Been Ordered 
--Task: Retrieve the names of products that have never been ordered.

SELECT * FROM Products
SELECT * FROM OrderDetails

SELECT ProductName 
FROM Products 
WHERE ProductID NOT IN (SELECT ProductID FROM OrderDetails);
