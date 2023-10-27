create database Student_Management

create table Student (
    StudentId int primary key identity(1,1),
    Name varchar(max),
    DateOfBirth date)

create table Courses (
    CourseId int primary key identity(1,1),
    CourseName nvarchar(255))

create table Enrollments (
    EnrollmentId int primary key identity(1,1),
    StudentId int,
    CourseId int,
    EnrollmentDate date,
    foreign key (StudentId) references Student(StudentId),
    foreign key (CourseId) references Courses(CourseId))
