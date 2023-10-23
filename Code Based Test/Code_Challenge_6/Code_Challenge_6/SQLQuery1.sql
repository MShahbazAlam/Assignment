create database Code_Challenge_6

use Code_Challenge_6

Create table Code_Employee(empno int primary key,
empname varchar(35) not null,
empsal numeric(10,2) check (empsal >=25000),
emptype char(1) check (emptype in ('F','P')))

create procedure AddEmployee
@empname varchar(35),
@empsal numeric(10,2),
@emptype char(1)
as
begin
declare @new_empno int

-- Generate a new employee number
select @new_empno = isnull(max(empno), 0) + 1 from Code_Employee

-- Insert the new employee record
insert into  Code_Employee (empno, empname, empsal, emptype)
values (@new_empno, @empname, @empsal, @emptype)

select @new_empno as 'New Employee Number'
end
-- Example usage:
exec AddEmployee 
@empname = 'Shahbaz',
@empsal= 30000.00,
@emptype= 'F'

select * from Code_Employee





use Assignment_2

declare @EmpNo int
declare @Sal int

-- Cursor Declaration
declare EmployeeCursor cursor for
select EmpNo, Sal
from EMP
where DeptNo = 10

-- Cursor open
open EmployeeCursor 

--first row
fetch next from EmployeeCursor into @EmpNo, @Sal

-- Loop through the cursor
while @@fetch_status = 0
begin
set @Sal = @Sal * 1.15

-- Updating the salary with a 15% increase
update EMP
set sal = sal * 1.15
where EmpNo = @EmpNo

-- Fetching the next row
fetch next from EmployeeCursor into @empno, @sal
end

close EmployeeCursor
deallocate EmployeeCursor


-- Select the updated records to verify
select * from EMP where DeptNo = 10
