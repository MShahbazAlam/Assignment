// Solution_2 of Assignment 5
using System;

namespace Assignment_5
{
    class Solution_2
    {
        static void Main()
        {
            Console.WriteLine("Enter the String :");
            string input = Console.ReadLine();
            Console.WriteLine("Enter your letter to count occurrences : ");
            char letter = Convert.ToChar(Console.ReadLine());

            int count = 0;
             foreach(char x in input)
            {
                if (x == letter)
                {
                    count++;
                }
            }
            Console.WriteLine("{0} total count is {1}", letter, count);

            Console.ReadLine();
        }
    }
}
