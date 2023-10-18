create database Assignment_5

use Assignment_5

create procedure Payslip
    @EmployeeID int,
    @Salary decimal(10, 2)
as
begin
declare @HRA decimal(10, 2)
declare @DA decimal(10, 2)
declare @PF decimal(10, 2)
declare @IT decimal(10, 2)
declare @Deductions decimal(10, 2)
declare @GrossSalary decimal(10, 2)
declare @NetSalary decimal(10, 2)

-- Calculate HRA, DA, PF, and IT
set @HRA = 0.10 * @Salary
set @DA = 0.20 * @Salary
set @PF = 0.08 * @Salary
set @IT = 0.05 * @Salary

-- Calculate Deductions
set @Deductions = @PF + @IT

-- Calculate Gross Salary
set @GrossSalary = @Salary + @HRA + @DA

-- Calculate Net Salary
set @NetSalary = @GrossSalary - @Deductions

-- Display the payslip
select 'Employee ID: ' + cast(@EmployeeID as varchar(10)) as 'Payslip',
'Basic Salary: ' + cast(@Salary as varchar(10)) as ' ',
'HRA: ' + cast(@HRA as varchar(10)) as' ',
'DA: ' + cast(@DA as varchar(10)) as ' ',
'PF: ' + cast(@PF as varchar(10)) as ' ',
'IT: ' + cast(@IT as varchar(10)) as ' ',
'Deductions: ' + cast(@Deductions as varchar(10)) as ' ',
'Gross Salary: ' + cast(@GrossSalary as varchar(10)) as' ',
'Net Salary: ' + cast(@NetSalary as varchar(10)) as ' '
end
exec Payslip @EmployeeID = 1, @Salary = 45000.00