use Assignment_2

-- Creating procedure
create procedure Payslip
@EmployeeID int
as
begin
    declare @EmployeeName varchar(255)
    declare @Sal int
    declare @HRA int
    declare @DA int
    declare @PF int
    declare @IT int
    declare @Deductions int
    declare @GrossSalary int
    declare @NetSalary int

-- fetching employee details
select @EmployeeName = Ename, @Sal = Sal
from EMP
where EmpNo = @EmployeeID

-- Calculate HRA, DA, PF, IT
set @HRA = @Sal * 0.10
set @DA = @Sal * 0.20
set @PF = @Sal * 0.08
set @IT = @Sal * 0.05

-- Calculate Deductions
set @Deductions = @PF + @IT

-- Calculate Gross Salary
set @GrossSalary = @Sal + @HRA + @DA

-- Calculate Net Salary
set @NetSalary = @GrossSalary - @Deductions

-- Print the payslip
print 'Employee Name: ' + @EmployeeName
print 'Salary: ' + cast (@Sal as varchar (255))
print 'HRA: ' + cast (@HRA as varchar (255))
print 'DA: ' + cast (@DA as varchar (255))
print 'PF: ' + cast (@PF as varchar (255))
print 'IT: ' + cast (@IT as varchar (255))
print 'Deductions: ' + cast (@Deductions as varchar (255))
print 'Gross Salary: ' + cast (@GrossSalary as varchar (255))
print 'Net Salary: ' + cast (@NetSalary as varchar (255))
end
-- Execute the procedure to generate a payslip for employee with EmpNo 7369
exec Payslip @EmployeeID = 7369
