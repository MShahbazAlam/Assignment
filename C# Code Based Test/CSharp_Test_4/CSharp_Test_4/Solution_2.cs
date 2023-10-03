using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Test_4
{
    
   public delegate double CalculatorOperation(double num1, double num2);

    class Solution_2
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select option to do operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Divide");

                
                int choice = int.Parse(Console.ReadLine());
                CalculatorOperation operation; //creating object of delegate
                switch (choice)
                {
                    case 1:
                        operation = Add;
                        break;
                    case 2:
                        operation = Subtract;
                        break;
                    case 3:
                        operation = Multiply;
                        break;
                    case 4:
                        operation = Divide;
                        break;
                    default:
                        operation = null; 
                        break;
                }

               
                if (operation != null)
                {
                    Console.Write("Enter the first number: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double result = operation(num1, num2);

                    Console.WriteLine($"Result : {result}");
                }
            }
        }

        // Calculator functions methods
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }
            return a / b;
        }
    }

}
