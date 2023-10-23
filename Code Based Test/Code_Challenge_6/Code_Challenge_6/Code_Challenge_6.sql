create database Code_Challenge_6

use Code_Challenge_6

Create table Code_Employee(empno int primary key,
empname varchar(35) not null,
empsal numeric(10,2) check (empsal >=25000),
emptype char(1) check (emptype in ('F','P')))

create procedure AddEmployee
@empname_param varchar(35),
@empsal_param numeric(10,2),
@emptype_param char(1)
as
begin
    declare @new_empno int

    -- Generate a new employee number
    select @new_empno = isnull(max(empno), 0) + 1 from Code_Employee

    -- Insert the new employee record
    insert into  Code_Employee (empno, empname, empsal, emptype)
    values (@new_empno, @empname_param, @empsal_param, @emptype_param)

    select @new_empno as 'New Employee Number'
end
-- Example usage:
exec AddEmployee 
@empname_param = 'Shahbaz',
@empsal_param = 30000.00,
@emptype_param = 'F'

select * from Code_Employee

