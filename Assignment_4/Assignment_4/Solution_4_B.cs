using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    
    class Student
    {

        private int rollNo;
        private string name;
        private string className;
        private string semester;
        private string branch;
        private int[] marks = new int[5];

        // Constructor
        public Student(int rollNo, string name, string className, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

        // marks entry 
        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1} Marks: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // calculate and display result
        public void DisplayResult()
        {
            int totalMarks = 0;
            foreach (int mark in marks)
            {
                totalMarks += mark;
            }

            double averageMarks = totalMarks / 5;
            Console.WriteLine($"Average Marks is : {averageMarks}");

            bool failed = false;

            foreach (int mark in marks)
            {
                if (mark < 35)
                {
                    failed = true;
                    break;
                }
            }

            if (failed || averageMarks < 50)
            {
                Console.WriteLine("Result : Failed");
            }
            else
            {
                Console.WriteLine("Result : Passed");
            }
        }


        public void DisplayData()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Details:");
            Console.Write("Roll No: ");
            int rollNo = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Class: ");
            string className = Console.ReadLine();

            Console.Write("Semester: ");
            string semester = Console.ReadLine();

            Console.Write("Branch: ");
            string branch = Console.ReadLine();

            // Student object
            Student student = new Student(rollNo, name, className, semester, branch);


            student.GetMarks();


            student.DisplayResult();


            student.DisplayData();

            Console.ReadLine();
        }
    }

}
