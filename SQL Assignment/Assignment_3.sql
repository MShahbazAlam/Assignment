create database Assignment_3
use Assignment_3

-- Creating EMP Table
create table EMP (
EmpNo int Primary key, Ename varchar(20) Not Null, Job varchar(15), MgrId int, HireDate Date, Sal int, Comm int, DeptNo int Not Null )

-- Creating DEPT Table
create table DEPT (
DeptNo int, Dname varchar(15), Loc varchar(15)) 

--Insert into EMP table

insert into EMP values 
	(7369, 'SMITH',	 'CLERK',		7902, '1980-12-17', 800, NULL,	20),
	(7499, 'ALLEN',	 'SALESMAN',	7698, '1981-02-20', 1600, 300,	30),
	(7521, 'WARD',	 'SALESMAN',	7698, '1981-02-22', 1250, 500,	30),
	(7566, 'JONES',	 'MANAGER',		7839, '1981-04-02', 2975, NULL,	20),
	(7654, 'MARTIN', 'SALESMAN',	7698, '1981-09-28', 1250, 1400,	30),
	(7698, 'BLAKE',	 'MANAGER',		7839, '1981-05-01', 2850, NULL,	30),
	(7782, 'CLARK',	 'MANAGER',		7839, '1981-06-09', 2450, NULL,	10),
	(7788, 'SCOTT',	 'ANALYST',		7566, '1987-04-19', 3000, NULL,	20),
	(7839, 'KING',	 'PRESIDENT',	NULL, '1981-11-17', 5000, NULL,	10),
	(7844, 'TURNER', 'SALESMAN',	7698, '1981-09-08', 1500, 0,	 30),
	(7876, 'ADAMS',	 'CLERK',		7788, '1987-05-23', 1100, NULL,	20),
	(7900, 'JAMES',	 'CLERK',		7698, '1981-12-03', 950, NULL,	30),
	(7902, 'FORD',	 'ANALYST',		7566, '1981-12-03', 3000, NULL,	20),
	(7934, 'MILLER', 'CLERK',		7782, '1982-01-23', 1300, NULL,	10)

select * from EMP
--Insert into Dept table

insert into DEPT values
	(10, 'ACCOUNTING', 'NEW YORK'),
	(20, 'RESEARCH', 'DALLAS'),
	(30, 'SALES', 'CHICAGO'),
	(40, 'OPERATIONS', 'BOSTON')

select * from DEPT

--	1. Retrieve a list of MANAGERS.
select * 
from EMP 
where Job = 'Manager'

--	2. Find out the names and salaries of all employees earning more than 1000 per month.
select Ename,Sal 
from EMP 
where sal > 1000

--	3. Display the names and salaries of all employees except JAMES.
select Ename,Sal 
from EMP 
where not Ename = 'James'

--	4. Find out the details of employees whose names begin with ‘S’. 
select * 
from EMP 
where  Ename like 's%'

--	5. Find out the names of all employees that have ‘A’ anywhere in their name.
select Ename 
from EMP 
where Ename like '%a%'

--	6. Find out the names of all employees that have ‘L’ as their third character in their name.
select Ename 
from EMP 
where Ename like '__l%'

--	7. Compute daily salary of JONES. 
select (sal/30)  as 'DailySalary' 
from EMP 
where Ename = 'Jones'

--	8. Calculate the total monthly salary of all employees. 
select sum(Sal) as 'TotalMonthlySalary' 
from EMP

--	9. Print the average annual salary.
select avg(Sal)*12 as 'Average Annual Salary' 
from EMP 

--	10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
select ename, job, sal, deptno 
from EMP 
where not job = 'SALESMAN'  and  deptno = 30

--	11. List unique departments of the EMP table.
select distinct DeptNo 
from EMP

--	12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select Ename as Employee, Sal as "Monthly Salary"
from EMP
where Sal > 1500 and (DeptNo = 10 or DeptNo = 30)

--	13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000.
select Ename, Job, Sal
from EMP
where (Job = 'Manager' OR Job = 'Analyst') and Sal not in (1000, 3000, 5000)

--	14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
select Ename, Sal, Comm
from EMP
where Comm > Sal * 1.10

--	15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select Ename
from EMP
where (Ename LIKE '%L%L%' or (DeptNo = 30 or MgrId = 7782))

--	16. Display the names of employees with experience of over 30 years and under 40 yrs Count the total number of employees.
select Ename
from EMP
where datediff(year, HireDate, getdate()) > 30 and datediff(year, HireDate, getdate()) < 40

select count(*) as 'Total Employees'
from EMP
where datediff(year, HireDate, getdate()) > 30 and datediff(year, HireDate, getdate()) < 40

--	17. Retrieve the names of departments in ascending order and their employees in descending order.
select D.DeptNo, D.Dname, D.Loc, E.Ename
from DEPT D left join EMP E on D.DeptNo = E.DeptNo
order by D.Dname asc, E.Ename desc

--	18. Find out experience of MILLER.
select Ename, datediff(year, HireDate, getdate()) as Experience
from EMP
where Ename = 'Miller'
