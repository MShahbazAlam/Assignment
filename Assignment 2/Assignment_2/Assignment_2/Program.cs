using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
    //Q.1.  Write a  Program to assign integer values to an array  and then print the following
    //a.	Average value of Array elements
    //b.    Minimum and Maximum value in an array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n]; //input value in array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the elements of array {i + 1} :");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Calculate Average Value Of Array
            double sum=0;
            foreach(int num in numbers)
            {
                sum += num;
                double average = sum / n;
            }
            // Minimum and Maximum value in an array
            int min = numbers[0];
            int max = numbers[0];
            foreach(int num in numbers)
            {
                num < min
            }
        }
    }
}
