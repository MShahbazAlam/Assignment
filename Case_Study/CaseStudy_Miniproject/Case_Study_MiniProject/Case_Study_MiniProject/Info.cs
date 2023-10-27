using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_MiniProject
{
    class Info
    {
        public void Display(Student student)
        {
            Console.WriteLine("Student ID: " + student.StudentId);
            Console.WriteLine("Student Name: " + student.StudentName);
            Console.WriteLine("Date of Birth: " + student.DateOfBirth.ToShortDateString());
        }
    }
}
