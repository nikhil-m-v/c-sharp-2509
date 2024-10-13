----Assignment 1:  
----Retrieve Employees and Their Department Names (INNER JOIN) 
----Task: Retrieve the employee names and their corresponding department names. 

SELECT * FROM Employees
SELECT * FROM Departments

SELECT employees.EmployeeFirstName, departments.departmentname
FROM employees
INNER JOIN departments
ON employees.departmentid = departments.departmentid;

----Assignment 2:  
----Retrieve All Employees and Their Department Names, Including Those Without 
----Departments (LEFT JOIN) 
----Task: Retrieve the employee names and their corresponding department names. Include 
----employees who are not assigned to any department.

SELECT * FROM Employees
SELECT * FROM Departments

SELECT Employees.EmployeeFirstName,Departments.DepartmentName FROM Employees LEFT JOIN Departments ON employees.departmentid = departments.departmentid;

----Assignment 3:  
----Retrieve All Departments and the Employees Working in Them (RIGHT JOIN) 
----Task: Retrieve all departments and their respective employees. Include departments even if they 
----don’t have any employees. 

SELECT Employees.EmployeeFirstName,Departments.DepartmentName FROM Employees RIGHT JOIN Departments ON employees.departmentid = departments.departmentid;

----Assignment 4:  
----Retrieve All Employees and Departments, Including Those Without Matches (FULL 
----OUTER JOIN) 
----Task: Retrieve all employees and all departments, including employees without a department 
----and departments without employees. 

SELECT Employees.EmployeeFirstName,Departments.DepartmentName FROM Employees FULL OUTER JOIN Departments ON employees.departmentid = departments.departmentid;

----Assignment 5:  
----Retrieve Orders and the Customers Who Placed Them (INNER JOIN) 
----Task: Retrieve order IDs and customer names for all orders. 

SELECT * FROM Orders
SELECT * FROM Customers

SELECT Orders.OrderID,Customers.CustomerName from Orders INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID

----Assignment 6:  
----Retrieve Orders and Customers, Including Customers Without Orders (LEFT JOIN) 
----Task: Retrieve all customers and their respective orders. Include customers even if they haven’t 
----placed any orders.

SELECT Orders.OrderID,Customers.CustomerName from Customers LEFT JOIN Orders ON Orders.CustomerID = Customers.CustomerID

----Assignment 7:  
----Retrieve Products and Their Categories (INNER JOIN) 
----Task: Retrieve product names and their respective category names. 

SELECT * FROM Products
SELECT * FROM Categories

SELECT Products.ProductName,Categories.CategoryName FROM Products INNER JOIN Categories ON Products.CategoryID=Categories.CategoryID

----Assignment 8:  
----Retrieve All Categories and Products, Including Categories Without Products (RIGHT 
----JOIN) 
----Task: Retrieve all categories and the products in each category. Include categories that don’t 
----have any products.

SELECT Products.ProductName,Categories.CategoryName FROM Products RIGHT JOIN Categories ON Products.CategoryID=Categories.CategoryID

----Assignment 9:  
----Retrieve Employees and Their Managers (Self-Join) 
----Task: Retrieve the employee names and the names of their managers. 

--create table employee(employeeid int primary key identity, employeename varchar(50), managerid int);
--INSERT INTO employee(employeename) values ('Ravi')
--INSERT INTO employee(employeename,managerid) values('Raj',4),('Sachin',2),('Sajin',1)
select * from employee
select e1.employeename,e2.employeename as manager from employee e1 inner join employee e2 on e1.managerid=e2.employeeid 

----Assignment 10:  
----Get All Possible Combinations of Products and Orders (CROSS JOIN) 
----Task: Retrieve all possible combinations of products and orders (cartesian product).

SELECT * FROM Products
SELECT * FROM OrderDetails

SELECT Products.ProductName, OrderDetails.OrderID 
FROM Products 
CROSS JOIN OrderDetails;
