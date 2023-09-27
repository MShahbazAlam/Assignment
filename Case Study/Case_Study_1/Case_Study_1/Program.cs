using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create Student class (id, name, dateofbirth)
  - Cover constructors, getters and setters

- Create class Info
  - Write a method called as:
	public void display(Student student) {
		//Code here to display the details of given student
	}

- Create App class with main method. Then

  - Write a method called as scenario1 to:
	- Create few objects of Student class
	- Call the display method of Info class

  - Write a method called as scenario2 to:
	- Create array of Student class and store few objects in it
	- Demonstrate how to iterate over the array and call the display method for each student*/
namespace Case_Study_1
{
	class Student
    {
		public int Id { get; set; } 
		public string Name { get; set; }
		public DateTime Dateofbirth { get; set; }
		
		public Student(int id, string name, DateTime dob)
        {
			this.Id = id;
			this.Name = name;
			this.Dateofbirth = dob;

        }
    }
	class Info
    {
		public void display(Student student)
		{
			Console.WriteLine("Student Id is: {0} \nStudent Name is: {1} \nStudent Date Of Birth is: {2}",student.Id,student.Name,student.Dateofbirth.ToShortDateString());
			
		}

	}
	class Program
    { 
		public void scenario1()
        {
            Console.WriteLine("Students Details by Making Object of Class");
			 Student student1 = new Student(10, "shahbaz", new DateTime (2002,02,02));
			Student student2 = new Student(12,"Alam", new DateTime(2003,01,01));

			Info info = new Info();
			info.display(student1);
			info.display(student2);
            Console.WriteLine("-------------------------------\n");
        }


		public void scenario2()
        {
            Console.WriteLine("Student Details Entry By Making Array ");
			Info info = new Info();
			Console.WriteLine("Enter the no of student ");
			int noOfStudent = Convert.ToInt32(Console.ReadLine());
			Student[] stud = new Student[noOfStudent];
			int countofStudent = 1;
            for(int i =0; i < noOfStudent;i++)
            {
                Console.WriteLine("Enter the details of student {0} ",countofStudent);
                Console.WriteLine("Enter student id: ");
				int _id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student name ");
				string _name = Console.ReadLine();
                Console.WriteLine("Enter date of birth: (yyyy-mm-dd)");
				DateTime _dob = Convert.ToDateTime(Console.ReadLine());

				stud [i] = new Student(_id, _name, _dob);
				countofStudent++;
			}

            Console.WriteLine("Students  Information By Array");
			foreach (Student s in stud)
			{
				info.display(s);
				Console.WriteLine();

			}

        }

		static void Main(string[] args)
		{
			Program p = new Program();
			p.scenario1();
			p.scenario2();
			Console.Read();

		}
    }
}
