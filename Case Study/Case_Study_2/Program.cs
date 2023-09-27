using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case_Study_1;
/*- Create Enroll class with the following structure:
   - public class Enroll {
	private Student student;
	private Course course;
	private LocalDate enrollmentDate;

	//constructors & getters/setters
     }

- Next create AppEngine class which will contain the following methods:

  - public void introduce(Course course) {

    }

  - public void register(Student student) {

    }

  - public Student[] listOfStudents() {

    }

  - public Course[] listOfCourses() {

    }

  - public void enroll(Student student, Course course) {

    }

  - public Enroll[] listOfEnrollments() {

    }

- Write App class with main method to test the above functionalities
  - Now modify Info class by adding new methods for displaying Enrollment details*/
namespace Case_Study_2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student(int id, string name, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
        }
    }

    public class Course
    {
        public int CourseId; 
        public string CourseName { get; set; }

        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }
    }

    public class Enroll
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            Student = student;
            Course = course;
            EnrollmentDate = enrollmentDate;
        }
    }

    public class AppEngine
    {
        private Student[] students;
        private Course[] courses;
        private Enroll[] enrollments;

        public AppEngine()
        {
            students = new Student[0];
            courses = new Course[0];
            enrollments = new Enroll[0];
        }

        public void Introduce(Course course)
        {
            // Logic to introduce a new course
        }

        public void Register(Student student)
        {
            // Logic to register a new student
        }

        public Student[] ListOfStudents()
        {
            return students;
        }

        public Course[] ListOfCourses()
        {
            return courses;
        }

        public void Enroll(Student student, Course course)
        {
            // Logic to enroll a student in a course
        }

        public Enroll[] ListOfEnrollments()
        {
            return enrollments;
        }
    }

    public class App
    {
        public static void Main(string[] args)
        {
            // Test the functionalities of Case Study 2
            AppEngine engine = new AppEngine();

            // Implement your testing scenarios here

            Console.ReadKey();
        }
    }
}
