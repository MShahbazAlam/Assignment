create database Code_Based_Test_5
use Code_Based_Test_5
create table Books ( 
Id int primary key, Title varchar(25), Author varchar(20), ISBN varchar(15) unique, Published_Date datetime)

insert into Books values
    (1, 'My First SQL', 'Mary Porker', '981483029127', '2012-02-22 12:08:00'),
    (2, 'My Second SQL book', 'John Mayer', '857300923713', '1972-07-03 09:22:00'),
    (3, 'My Third SQL book', 'Cary Flint', '523120967812', '2015-10-18 00:00:00')

select * from Books

select *
from Books
where Author like '%er'

-------------------------------------------------

create table Reviews (
Id int foreign key references Books (Id), Book_Id int, Reviewer_name varchar (20), Content varchar(30), Rating  int, Published_Date datetime) 

insert into Reviews values
    (1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11'),
    (2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
    (3, 2, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10')

--2nd query
select  * from Reviews
select B.Title, B.Author, R.Reviewer_name
from Books as B
join Reviews as R on B.Id = R.Book_Id;

------------------------------------------------------------------------------
-- 3rd Query
select Reviewer_name
from Reviews
group by Reviewer_name
having count (distinct Book_Id) > 1

----------------------------------------
create table Customers (
Id int primary key, C_Name varchar(15), Age int, C_Address varchar (20), Salary decimal(10,2)) 

insert into Customers values 
    (1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
    (2, 'Khilan', 25, 'Delhi', 1500.00),
    (3, 'Kaushik', 23, 'Kota', 2000.00),
    (4, 'Chaitali', 25, 'Mumbai', 6500.00),
    (5, 'Hardik', 27, 'Bhopal', 8500.00),
    (6, 'Komal', 22, 'MP' , 4500.00),
    (7, 'Muffy', 24, 'Indore', 10000.00)

select * from Customers

select C_Name
from Customers
where C_Address like '%o%'

---------------------------------------------------------
	create table Orders (
	OId int,O_Date datetime, Customer_Id int foreign key references Customers (Id), Amount decimal(7,2))

	insert into Orders values
		(102, '2009-10-08 00:00:00', 3, 3000.00),
		(100, '2009-10-08 00:00:00', 3, 1500.00),
		(101, '2009-11-20 00:00:00', 2, 1560.00),
		(103, '2008-05-20 00:00:00', 4, 2060.00)

	select * from Orders

	select O_Date as date, COUNT( Customer_Id) as "Total Customers"
	from Orders
	group by O_Date
	having count(Customer_Id) > 1


	------------------------------------------------------------
create table Employee (
Id int, E_Name varchar(20), Age int, E_Address varchar(25), Salary decimal(7,2))

insert into Employee values
	(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
    (2, 'Khilan', 25, 'Delhi', 1500.00),
    (3, 'Kaushik', 23, 'Kota', 2000.00),
    (4, 'Chaitali', 25, 'Mumbai', 6500.00),
    (5, 'Hardik', 27, 'Bhopal', 8500.00),
    (6, 'Komal', 22, 'MP' ,null ),
    (7, 'Muffy', 24, 'Indore',null)

select * from Employee

select lower(E_Name) as Lowercase_Name
from Employee
where Salary is null
-------------------------------------------------------
create table StudentDetails ( 
Id int, RegisterNo int, S_Name varchar (20), Age int , Qualification varchar(10),MobileNo varchar (10), Mail_id varchar (20), Location varchar (15), gender varchar(1))

select * from StudentDetails
insert into StudentDetails values 
  (1, 2,'Sai', 22, 'B.E','995283677','sai@gmail.com','chennai','M'),
    (2,3, 'Kumar', 20,'BSC','70015648','kumar@gmail.com','Madurai','M'),
    (3,4, 'Selvi', 22,'B.Tech','04567342','selvi@gmail.com','Selam','F'),
    (4, 5,'Nisha', 25,'M.E',  '734672310', 'Nisha@gmail.com','Theni','F'),
    (5,6,'SaiSaran',21,'B.A','790345678','saran@gmail.com','Madurai','F'),
    (6,7,'Tom',23,'BCA','890145675','Tom@gmail.com','Pune','M')

	select Gender , count(*) as totalcount
    from Studentdetails
	group by gender
