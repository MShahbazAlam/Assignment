using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Test_4
{
   class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;
    }

    class Solution_3
    {
        static void Main(string[] args)
        {
            
            List<Employee> employeeList = new List<Employee>
            {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = Convert.ToDateTime("16/11/1984"), DOJ =  Convert.ToDateTime("8/6/2011"), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB =  Convert.ToDateTime("20/08/1984"), DOJ =  Convert.ToDateTime("7/7/2012"), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB =  Convert.ToDateTime("14/11/1987"), DOJ =  Convert.ToDateTime("12/4/2015"), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB =  Convert.ToDateTime("3/6/1990"), DOJ =  Convert.ToDateTime("2/2/2016"), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB =  Convert.ToDateTime("8/3/1991"), DOJ =  Convert.ToDateTime("2/2/2016"), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB =  Convert.ToDateTime("7/11/1989"), DOJ =  Convert.ToDateTime("8/8/2014"), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB =  Convert.ToDateTime("2/12/1989"), DOJ =  Convert.ToDateTime("1/6/2015"), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB =  Convert.ToDateTime("11/11/1993"), DOJ =  Convert.ToDateTime("6/11/2014"), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB =  Convert.ToDateTime("12/8/1992"), DOJ =  Convert.ToDateTime("3/12/2014"), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB =  Convert.ToDateTime("12/4/1991"), DOJ =  Convert.ToDateTime("2/1/2016"), City = "Pune" }
             };

            Console.WriteLine("A. Details of all employees:\n");
            foreach (var emp in employeeList)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
                
            }

            Console.WriteLine("..............................................................");
            Console.WriteLine("\nB. Details of employees whose location is not Mumbai:\n");
            var employeesNotInMumbai = employeeList.Where(emp => emp.City != "Mumbai");
            foreach (var emp in employeesNotInMumbai)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }

            Console.WriteLine("..............................................................");
            Console.WriteLine("\nC. Details of employees whose title is AsstManager:\n");
            var asstManagers = employeeList.Where(emp => emp.Title == "AsstManager");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }

            Console.WriteLine("..............................................................");
            Console.WriteLine("\nD. Details of employees whose Last Name starts with S:\n");
            var employeesWithLastNameStartingWithS = employeeList.Where(emp => emp.LastName.StartsWith("S", StringComparison.OrdinalIgnoreCase));
            foreach (var emp in employeesWithLastNameStartingWithS)
            {
                Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToShortDateString()}, DOJ: {emp.DOJ.ToShortDateString()}, City: {emp.City}");
            }
            Console.ReadLine();
        }
    }
}