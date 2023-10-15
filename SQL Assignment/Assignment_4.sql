create database Assignment_4
use Assignment_4

-- Declare variables
declare @Number int = 5 -- Change this to the desired number for which you want to calculate the factorial
declare @Factorial bigint = 1
declare @Counter int = 1

-- Calculate factorial using a loop
while @Counter <= @Number
begin
    set @Factorial = @Factorial * @Counter
    set @Counter = @Counter + 1
end

-- Output the factorial result
select 'The factorial of ' + cast(@Number as varchar) + ' is ' + cast(@Factorial as varchar)


--------------------------------------------------------------------------------------------------------------------------

-- Create a stored procedure to generate multiplication tables
create procedure MultiplicationTable
@Number int
as
begin
declare @Multiplier int = 1

    -- Check if the input number is greater than 0
    if @Number <= 0
    begin
        print'Please provide a positive number.'
        return
    end

    -- Loop to generate the multiplication table
    while @Multiplier <= @Number
    begin
        declare @Multiplicand int = 1
        while @Multiplicand <= @Number
        begin
            print cast(@Multiplier as nvarchar(10)) + ' x ' + cast(@Multiplicand as nvarchar(10)) + ' = ' + cast(@Multiplier * @Multiplicand as nvarchar(10))
            set @Multiplicand = @Multiplicand + 1;
        end
        print '' -- Add a blank line to separate tables
        set @Multiplier = @Multiplier + 1;
    end
end

-- Execute the stored procedure and provide the desired number
exec MultiplicationTable @Number = 10


-----------------------------------------------------------------------------------------------------------------------------------

use Assignment_2

create table Holidays
(holiday_date date primary key, holiday_name nvarchar(max))

insert into Holidays values
('2023-11-30','Diwali'),
('2023-08-15','Independence Day'),
('2023-05-11','Eid'),
('2023-10-02','Gandhi jayanthi')

-- Creating trigger
create trigger RestrictChanges
on EMP
for insert, update, delete
as
begin
    declare @HolidayName varchar(max)
    declare @IsHoliday int

    -- Check if it's a holiday
    select @IsHoliday = count(*), @HolidayName = Holiday_name
    from Holidays
    where holiday_date = cast(getdate() as date)

    -- If it's a holiday, prevent data manipulation and display an error message
    if @IsHoliday > 0
    begin
        raiserror('Due to %s, you cannot manipulate data', 16, 1, @HolidayName)
        rollback transaction
    end
end

select * from EMP

insert into EMP values(7370,'Puneet', 'Dev', 1914,'2001-05-29',9000,null,10)