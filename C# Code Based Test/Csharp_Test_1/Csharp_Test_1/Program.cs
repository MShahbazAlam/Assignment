using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Test_1
{
    class Test_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".............Solution of Question-1.............. ");

            Console.WriteLine(RemoveCharacter("Python", 1));
            Console.WriteLine(RemoveCharacter("Python", 0));
            Console.WriteLine(RemoveCharacter("Python", 4));
            Console.WriteLine(".....................................");

            Console.WriteLine(".............Solution of Question-2..............");

            Console.Write("Enter the number of which Table you want: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Multiplication(number);

            Console.ReadLine();
        }

        public static string RemoveCharacter(string input, int position)
        {
            
            if (position < 0 || position >= input.Length)
            {
                // If the position is not in range, return the original .
                return input;
            }

            string result = input.Remove(position, 1);

            return result;
        }


        public static void Multiplication(int number)
        {
           
            Console.WriteLine($"Multiplication Table for {number}:");

            for (int i = 0; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }


    }

}

