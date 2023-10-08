create database Assignment_2
use Assignment_2

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
	(40, 'OPERATIONS', 'BOSTON');

select * from DEPT


--	1. List all emplozXyees whose name begins with 'A'.
select Ename 
from EMP 
where Ename LIKE 'A%'

--	2. Select all those employees who don't have a manager. 
select EName 
from EMP 
where MgrId is null

--	3. List employee name, number and salary for those employees who earn in the range 1200 to 1400.
select Ename,EmpNo,Sal 
from EMP 
where (sal > 1200 and sal < 1400)

--	4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.

-- Before pay rise
SELECT *
FROM EMP
WHERE deptno = 20

-- Apply pay rise
UPDATE EMP
SET sal = sal * 1.10
WHERE deptno = 20

-- After pay rise
SELECT *FROM EMP
WHERE deptno = 20

--	5. Find the number of CLERKS employed. Give it a descriptive heading. 
select count(*) 
as "Number Of Clerks" 
from EMP 
where job ='clerk'

--	6. Find the average salary for each job type and the number of people employed in each job. 
select Job, 
avg(sal) as "Average Salary",
count(*) as "Number of Employees" 
from EMP 
group by job

--	7. List the employees with the lowest and highest salary. 
select ename, sal 
from emp 
where sal =(select min(sal) from emp) or sal =(select max(sal) from emp)

--	8. List full details of departments that don't have any employees.

select * 
from DEPT D
LEFT JOIN EMP E on D.DeptNo = E.DeptNo
where E.EmpNo is null

--	9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ename, sal 
from EMP
where job = 'Analyst' And sal > 1200 And deptno = 20
order by ename asc

--	10. For each department, list its name and number together with the total salary paid to employees in that department.
select d.dname, d.deptno, 
sum(e.sal) as "Total Salary" 
FROM DEPT d
LEFT JOIN EMP e on d.deptno = e.deptno
group by d.dname, d.deptno

--	11. Find out salary of both MILLER and SMITH.
select ename, sal
from EMP
where ename in ('MILLER', 'SMITH')

--	12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
select ename 
from EMP
where ename like '[am]%'

--	13. Compute yearly salary of SMITH.
select ename, sal * 12 as "Yearly Salary"
from EMP
where ename = 'SMITH'

--	14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ename, sal 
from EMP
where sal < 1500 or sal > 2850

--	15. Find all managers who have more than 2 employees reporting to them
select MgrId, 
count(*) as EmployeeCount
from EMP
where Job = 'MANAGER'
group by MgrId
having count(*) > 2
