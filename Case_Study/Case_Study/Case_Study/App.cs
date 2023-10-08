using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
   


    public class App
    {
        //public static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            AppEngine appEngine = new AppEngine();
            UserInterface userInterface = new UserInterface(appEngine);
            userInterface.ShowFirstScreen();


            /*
            Console.WriteLine("Welcome to Case Study 1!");
            while (true)
            {
                Console.WriteLine("\nChoose a scenario:");
                Console.WriteLine("1. Scenario 1");
                Console.WriteLine("2. Scenario 2");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Scenario1();
                            break;
                        case 2:
                            Scenario2();
                            break;
                        case 3:
                            Console.WriteLine("Exiting!");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid scenario (1-3).");

                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric choice.");
                }
            }
            */


            /*
            

             AppEngine appEngine = new AppEngine();

                Console.WriteLine("Welcome to the Course Enrollment System!");

                while (true)
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Introduce Course");
                    Console.WriteLine("2. Register Student");
                    Console.WriteLine("3. Enroll Student in Course");
                    Console.WriteLine("4. List Students");
                    Console.WriteLine("5. List Courses");
                    Console.WriteLine("6. List Enrollments");
                    Console.WriteLine("7. Exit");
                    Console.Write("Enter your choice (1-7): ");

                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.Write("Enter Course ID: ");
                                int courseId = int.Parse(Console.ReadLine());
                                Console.Write("Enter Course Name: ");
                                string courseName = Console.ReadLine();
                                appEngine.Introduce(new Course(courseId, courseName));
                                Console.WriteLine("Course introduced successfully.");
                                break;


                            case 2:
                                Console.WriteLine("\nChoose a scenario for student registration:");
                                Console.WriteLine("1. Scenario 1 (CaseStudy1)");
                                Console.WriteLine("2. Scenario 2 (CaseStudy1)");
                                Console.Write("Enter your choice (1-2): ");
                                //int scenarioChoice = int.Parse(Console.ReadLine());
                                if (int.TryParse(Console.ReadLine(), out int scenarioChoice))
                                {

                                    if (scenarioChoice == 1 || scenarioChoice == 2)
                                    {
                                        // Register the student using Scenario 1 or 2 from CaseStudy1
                                        if (scenarioChoice == 1)
                                        {
                                            App.Scenario1();
                                            Console.WriteLine("Student registered successfully using Scenario 1.");
                                        }
                                        else if (scenarioChoice == 2)
                                        {
                                            App.Scenario2();
                                            Console.WriteLine("Student registered successfully using Scenario 2.");
                                        }
                                    }


                                    else
                                    {
                                        Console.WriteLine("Please select a valid scenario (1-2).");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input, Please enter a numeric choice ");
                                }
                                break;



                            case 3:
                                Console.Write("Enter Student ID: ");
                                int enrollStudentId = int.Parse(Console.ReadLine());
                                Console.Write("Enter Course ID: ");
                                int enrollCourseId = int.Parse(Console.ReadLine());
                                Student enrollStudent = appEngine.ListOfStudents()
                                    .FirstOrDefault(s => s.Id == enrollStudentId);
                                Course enrollCourse = appEngine.ListOfCourses()
                                    .FirstOrDefault(c => c.CourseId == enrollCourseId);
                                if (enrollStudent != null && enrollCourse != null)
                                {
                                    appEngine.Enroll(enrollStudent, enrollCourse);
                                    Console.WriteLine("Student enrolled in the course successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Student or course not found. Please register them first.");
                                }
                                break;


                            case 4:

                                Console.WriteLine("\nList of Students:");
                                foreach (var student in Case_Study_1.App.students)
                                {
                                    Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}");
                                }
                                break;

                            case 5:
                                Console.WriteLine("\nList of Courses:");
                                foreach (var course in appEngine.ListOfCourses())
                                {
                                    Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");
                                }
                                break;

                            case 6:
                                Console.WriteLine("\nList of Enrollments:");
                                foreach (var enrollment in appEngine.ListOfEnrollments())
                                {
                                    Console.WriteLine($"Student ID: {enrollment.Student.Id}, Course ID: {enrollment.Course.CourseId}, Enrollment Date: {enrollment.EnrollmentDate}");
                                }
                                break;

                            case 7:
                                Console.WriteLine("Exiting the program. Goodbye!");
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please select a valid option.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric choice.");
                    }
                }
             */
        }

       /*
        public static void Scenario1()
        {
            Info info = new Info();

            Console.WriteLine("Scenario 1 - Create Student Objects and Display Details");
            Console.Write("Enter the number of students you want to create: ");
            int numStudents = int.Parse(Console.ReadLine());

            if (numStudents > 0)
            {
                for (int i = 1; i <= numStudents; i++)
                {
                    Console.WriteLine($"\nEnter details for Student {i}:");
                    Console.Write("Enter Student ID: ");
                    int studentId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Student Name: ");
                    string studentName = Console.ReadLine();
                    Console.Write("Enter Student Date of Birth (yyyy-MM-dd): ");
                    DateTime studentDob = DateTime.Parse(Console.ReadLine());

                    // Create the Student object
                    Student student = new Student(studentId, studentName, studentDob);
                    App.students.Add(student); // Add the student to the shared list

                    // Call the display method of Info to display student details
                    info.Display(student);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of students.");
            }
        }

        public static void Scenario2()
        {
            Info info = new Info();

            Console.WriteLine("\nScenario 2:");
            Console.Write("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter Student {i + 1} ID: ");
                int studentId = int.Parse(Console.ReadLine());
                Console.Write($"Enter Student {i + 1} Name: ");
                string studentName = Console.ReadLine();
                Console.Write($"Enter Student {i + 1} Date of Birth (yyyy-MM-dd): ");
                DateTime studentDob = DateTime.Parse(Console.ReadLine());

                // Create the Student object
                Student student = new Student(studentId, studentName, studentDob);
                App.students.Add(student); // Add the student to the shared list

                info.Display(student);
            }
        }*/

       

    }
}
