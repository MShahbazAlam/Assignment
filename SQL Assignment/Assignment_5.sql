CREATE DATABASE ASSIGNMENT_5
USE Assignment_5

Create procedure GeneratePayslip
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
    select 'Employee ID: ' + CAST(@EmployeeID AS VARCHAR(10)) AS 'Payslip',
           'Basic Salary: ' + CAST(@Salary AS VARCHAR(10)) AS ' ',
           'HRA: ' + CAST(@HRA AS VARCHAR(10)) AS ' ',
           'DA: ' + CAST(@DA AS VARCHAR(10)) AS ' ',
           'PF: ' + CAST(@PF AS VARCHAR(10)) AS ' ',
           'IT: ' + CAST(@IT AS VARCHAR(10)) AS ' ',
           'Deductions: ' + CAST(@Deductions AS VARCHAR(10)) AS ' ',
           'Gross Salary: ' + CAST(@GrossSalary AS VARCHAR(10)) AS ' ',
           'Net Salary: ' + CAST(@NetSalary AS VARCHAR(10)) AS ' ';
END
EXEC GeneratePayslip @EmployeeID = 1, @Salary = 2330000.00;