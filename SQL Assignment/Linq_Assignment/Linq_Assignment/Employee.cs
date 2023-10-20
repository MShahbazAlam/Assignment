using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            void DisplayEmployees(List<Employee> employees)
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.EmployeeID}\t{employee.FirstName}\t{employee.LastName}\t{employee.Title}\t{employee.DOB:d}\t{employee.DOJ:d}\t{employee.City}");
                }
            }

            List<Employee> empList = new List<Employee>
            {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984-11-16), DOJ = new DateTime(2011-08-06), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984-08-20), DOJ = new DateTime(2012-07-07), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987-11-14), DOJ = new DateTime(2015-12-04), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990-03-06), DOJ = new DateTime(2016-02-02), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991-08-03), DOJ = new DateTime(2016-02-02), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989-11-07), DOJ = new DateTime(2014-08-08), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989-12-02), DOJ = new DateTime(2015-01-06), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993-11-11), DOJ = new DateTime(2014-06-11), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992-12-08), DOJ = new DateTime(2014-03-12), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991-04-12), DOJ = new DateTime(2016-02-01), City = "Pune" }
            };

            // 1. Employees joined before 1/1/2015
            var employeesJoinedBefore2015 = empList.FindAll(e => e.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("Employees joined before 1/1/2015:");
            DisplayEmployees(employeesJoinedBefore2015);
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 2. Employees with DOB after 1/1/1990
            var employeesWithDOBAfter1990 = empList.FindAll(e => e.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("\nEmployees with DOB after 1/1/1990:");
            DisplayEmployees(employeesWithDOBAfter1990);
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 3. Employees with designation Consultant or Associate
            var consultantsAndAssociates = empList.FindAll(e => e.Title == "Consultant" || e.Title == "Associate");
            Console.WriteLine("\nEmployees with designation Consultant or Associate:");
            DisplayEmployees(consultantsAndAssociates);
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 4. Total number of employees
            int totalEmployees = empList.Count;
            Console.WriteLine($"\nTotal number of employees: {totalEmployees}");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 5. Total employees in Chennai
            int employeesInChennai = empList.Count(e => e.City == "Chennai");
            Console.WriteLine($"Total employees in Chennai: {employeesInChennai}");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 6. Highest Employee ID
            int highestEmployeeID = empList.Max(e => e.EmployeeID);
            Console.WriteLine($"Highest Employee ID: {highestEmployeeID}");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 7. Employees joined after 1/1/2015
            var employeesJoinedAfter2015 = empList.Count(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"Employees joined after 1/1/2015: {employeesJoinedAfter2015}");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 8. Total employees with designation not "Associate"
            int employeesNotAssociates = empList.Count(e => e.Title != "Associate");
            Console.WriteLine($"Total employees with designation not 'Associate': {employeesNotAssociates}");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 9. Total employees based on City
            var employeesByCity = empList.GroupBy(e => e.City).Select(group => new
            {
                City = group.Key,
                Count = group.Count()
            });
            Console.WriteLine("\nTotal employees based on City:");
            foreach (var cityGroup in employeesByCity)
            {
                Console.WriteLine($"{cityGroup.City}: {cityGroup.Count}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 10. Total employees based on City and Title
            var employeesByCityAndTitle = empList.GroupBy(e => new { e.City, e.Title }).Select(group => new
            {
                City = group.Key.City,
                Title = group.Key.Title,
                Count = group.Count()
            });
            Console.WriteLine("\nTotal employees based on City and Title:");
            foreach (var cityTitleGroup in employeesByCityAndTitle)
            {
                Console.WriteLine($"{cityTitleGroup.City}, {cityTitleGroup.Title}: {cityTitleGroup.Count}");
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // 11. Youngest employee
            var youngestEmployee = empList.OrderBy(e => e.DOB).First();
            Console.WriteLine($"\nYoungest Employee: {youngestEmployee.FirstName} {youngestEmployee.LastName}");

            Console.Read();
        }
    }
}
