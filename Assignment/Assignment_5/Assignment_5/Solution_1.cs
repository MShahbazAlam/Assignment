//Solution 1 of Assignment 5.
using System;


namespace Assignment_5
{
    class Solution_1
    {
        static void Display()
        {
            Console.WriteLine( "Enter First Name :");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lName = Console.ReadLine();
            Console.WriteLine(fName.ToUpper() + "\n" + lName.ToUpper());
        }

        static void Main(string[] args)
        {
            Display();
            Console.ReadLine();
        }
    }
}
