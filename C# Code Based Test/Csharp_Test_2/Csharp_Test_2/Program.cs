using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Test_2
{
    // Abstract class Student
    public abstract class Student
    {
        public string Name;
        public int StudentId;
        public double Grade;

        public abstract bool IsPassed(double grade);
    }

    // Subclass Undergraduate
    public class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    // Subclass Graduate
    public class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter details for an Undergraduate student:");
            Undergraduate undergraduateStudent = UndergraduateDetails();

            Console.WriteLine("Enter details for a Graduate student:");
            Graduate graduateStudent = GraduateDetails();

            // Checking Undergraduate student result
            Console.WriteLine("Result for Undergraduate ");
            Console.WriteLine("Name: " + undergraduateStudent.Name);
            Console.WriteLine("Student ID: " + undergraduateStudent.StudentId);
            bool UndergraduatePassed = undergraduateStudent.IsPassed(undergraduateStudent.Grade);
            Console.WriteLine("Passed: " + UndergraduatePassed);


            // Checking  Graduate student result
           Console.WriteLine("Result for Graduate ");
            Console.WriteLine("Name: " + graduateStudent.Name);
            Console.WriteLine("Student ID: " + graduateStudent.StudentId);
            bool GraduatePassed = graduateStudent.IsPassed(graduateStudent.Grade);
            Console.WriteLine("Passed: " + GraduatePassed);

            Console.ReadLine();
        }

        public static Undergraduate UndergraduateDetails()
        {
            Undergraduate student = new Undergraduate();

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Student ID: ");
            student.StudentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Grade: ");
            student.Grade = Convert.ToDouble(Console.ReadLine());

            return student;
        }

        static Graduate GraduateDetails()
        {
            Graduate student = new Graduate();

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Student ID: ");
            student.StudentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Grade: ");
            student.Grade = Convert.ToDouble(Console.ReadLine());

            return student;
        }
    }



}
