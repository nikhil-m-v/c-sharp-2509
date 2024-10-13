----GROUP BY HAVING CLAUSE 
----assign 1
--SELECT * FROM EMPLOYEE;
--SELECT * FROM DEPARTMENT;


--SELECT  d.departmentname,avg(e.salary) from Employee e inner join department d  on  e.departmentid= d.departmentid group by
--d.departmentname  having  avg(e.salary) > 50000;

----assign2
--SELECT  d.departmentname,count(*) as emp_count from Employee e inner join department d  on  e.departmentid= d.departmentid group by
--d.departmentname  having count(*) > 1;

----assign 3


--SELECT  d.departmentname,max(e.salary) as max_sal,min(e.salary) as min_sal from Employee e inner join department d  on  e.departmentid= d.departmentid group by
--d.departmentname  having min(salary)> 30000 ;


----assignment-4
--select *  from employee;
--select * from EmployeeSales;

--select e.firstname ,sum(s.amount) as total_sales from employee e inner join EmployeeSales s on
--e.employeeid=s.employeeid group by e.firstname;
----create table EmployeeSales(
----	SALESID  INT PRIMARY KEY IDENTITY(1,1),
----	Employeeid int,
----	amount decimal(10,2),



------);

------INSERT INTO  EmployeeSales (Employeeid, amount) VALUES (1, 25000),(9,6000),(10,5666),(12,444444);

------assign 5

--select * from customer;
--select * from orders;


--select  c.CustomerName  , count(*) as total_orders from customer c inner join 
--orders o on c.customerid=o.CustomerId group by c.CustomerName ;