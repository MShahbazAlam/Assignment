using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_MiniProject
{
    class UserInterface : IUserInterface
    {
        private readonly AppEngine appEngine;

        public UserInterface(AppEngine engine)
        {
            appEngine = engine;
        }
        public void showFirstScreen()
        {
            Console.WriteLine("Welcome to SMS (Student Management System)");
            Console.WriteLine("Tell Us Who are You \n1. Student \n2. Admin \n3. Exit");
            Console.WriteLine("Enter your Choice 1, 2 & 3");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    showAllStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\n\n Invalid choice. Please enter 1, 2 or 3.");
                    showFirstScreen();
                    break;
            }

        }
        public void showStudentScreen()
        {
            Console.WriteLine("------------ Student Screen -------------------");
            Console.WriteLine("1. Show All Students");
            Console.WriteLine("2. Enroll in a Course");
            Console.WriteLine("3. Show All Courses");
            Console.WriteLine("4. Go Back");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    showAllStudentScreen();
                    break;
                case 2:
                    EnrollStudentInCourseScreen();
                    break;
                case 3:
                    showAllCourseScreen();
                    break;
                case 4:
                    showFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    showStudentScreen();
                    break;
            }

        }
        public void showAdminScreen()
        {
            Console.WriteLine("------------- Admin Screen -------------");
            Console.WriteLine("1. Enroll New Student");
            Console.WriteLine("2. Show All Courses");
            Console.WriteLine("3. Introduce New Course");
            Console.WriteLine("4. Show All Student");
            Console.WriteLine("5. Show All Enrollments");
            Console.WriteLine("6. Go Back");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StudentRegistrationScreen();
                    break;
                case 2:
                    showAllCourseScreen();
                    break;
                case 3:
                    introduceNewCourseScreen();
                    break;
                case 4:
                    showAllStudentScreen();
                    break;
                case 5:
                    ShowAllEnrollments();
                    break;
                case 6:
                    showFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    showAdminScreen();
                    break;
            }

        }
        public void showAllStudentScreen()
        {
            List<Student> students = appEngine.GetStudents();

            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"Student ID: {student.StudentId}, Name: {student.StudentName}, Date of Birth: {student.DateOfBirth.ToShortDateString()}");
            }
            showAdminScreen();

        }
        public void StudentRegistrationScreen()
        {
            Console.WriteLine("Student Registration");
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter Date of Birth (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dateOfBirth))
            {
                Student student = new Student { StudentName = studentName, DateOfBirth = dateOfBirth };
                appEngine.RegisterStudent(student);
                Console.WriteLine("Student registered successfully.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Registration failed.");
            }
            showAdminScreen();
        }
        public void introduceNewCourseScreen()
        {
            Console.WriteLine("---------Introducing New Course-------------");
            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();
            Course course = new Course { CourseName = courseName };
            appEngine.IntroduceCourse(course);
            Console.WriteLine("Course introduced successfully.");
            showAllCourseScreen();
            showAdminScreen();
        }
        public void showAllCourseScreen()
        {
            List<Course> courses = appEngine.GetCourses();

            Console.WriteLine("List of Courses:");
            foreach (var course in courses)
            {
                Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");
            }
            showFirstScreen();
        }
        public void ShowAllEnrollments()
        {
            List<Enroll> enrollments = appEngine.GetEnrollments();

            Console.WriteLine("List of Enrollments:");
            foreach (var enrollment in enrollments)
            {
                Console.WriteLine($"Student ID: {enrollment.Student.StudentId}, Student Name: {enrollment.Student.StudentName}");
                Console.WriteLine($"Course ID: {enrollment.Course.CourseId}, Course Name: {enrollment.Course.CourseName}");
                Console.WriteLine($"Enrollment Date: {enrollment.EnrollmentDate.ToShortDateString()}");
                Console.WriteLine();
            }
            showAdminScreen();
        }
        public void EnrollStudentInCourseScreen()
        {
            showAllStudentScreen();
            Console.WriteLine("Enter Student ID to enroll: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            showAllCourseScreen();
            Console.WriteLine("Enter Course ID to enroll in: ");
            int courseId = Convert.ToInt32(Console.ReadLine());

            Student student = appEngine.GetStudentById(studentId);
            Course course = appEngine.GetCourseById(courseId);

            appEngine.EnrollStudentInCourse(student, course);
            Console.WriteLine("Student enrolled in the course successfully.");
            showStudentScreen();
        }

    }
}
