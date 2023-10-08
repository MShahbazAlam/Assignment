// Solution 4 of Assignment 5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Create a class called Customer with Customerid, Name, Age, Phone,City. 
Write a constructor with no arguments and another constructor with all information.  
Write a method called DisplayCustomer(), 
which is called directly without any object. Also  include destructor*/
namespace Assignment_5
{
    class Solution_4
    {
       public static void Main()
        {
            Console.Write("Enter Customer ID: ");
            string customerId = Console.ReadLine();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Phone: ");
            long phone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            // Customer object using the parameterized constructor
            Customer customer1 = new Customer(customerId, name, age, phone, city);

            // printing customer information using the static method
            Customer.DisplayCustomer(customer1);
            
            Console.WriteLine("Calling Default Constructor ");
            // another Customer object using the default constructor
            Customer customer2 = new Customer();

            // printing customer information using the static method
            Customer.DisplayCustomer(customer2);

            Console.Read();
            // The destructor will be automatically called when the program ends
        }
    }
    class Customer
    {
        string Customerid;
        string Name;
        int Age;
        long Phone;
        string City;

        public Customer()
        {

        }
        public Customer(string cutomerId, string name, int age, long phone, string city)
        {
            Customerid = cutomerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;

        }
        public static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine("Customer ID: " + customer.Customerid);
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("Age: " + customer.Age);
            Console.WriteLine("Phone: " + customer.Phone);
            Console.WriteLine("City: " + customer.City);

        }
        ~Customer()
        {
            
        }
    }
}
