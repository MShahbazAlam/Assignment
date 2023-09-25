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
		public int Id; 
		public string Name { get; set; }
		public DateTime Dateofbirth { get; set; }

		public Student(int id, string name, DateTime dob)
        {
			Id = id;
			Name = name;
			Dateofbirth = dob;
        }

    }

	class Info
    {
		public void display(Student student)
		{

            Console.WriteLine("Student Id is: {0} \nStudent Name is: {1} \nStudent Date Of Birth is: {2}",student.Id,student.Name,student.Dateofbirth);
			
		}

	}
	class Program
    { 
		public void scenario1()
        {
			// Student student1 = new Student(10, "shahbaz", 0222);
			// Student student2 = new Student();

			//Info info = new Info();
			//info.display(student1);
			//info.display(student2);

        }


		public void scenario2()
        {
			Student[] stud = new Student[1];
			stud[0] = new Student(3, "sh", new DateTime(2002,02,15));

			Info info = new Info();
			info.display(stud[0]);

        }

		static void Main(string[] args)
		{
			Program p = new Program();
			p.scenario2();
			Console.Read();

		}
    }
}
