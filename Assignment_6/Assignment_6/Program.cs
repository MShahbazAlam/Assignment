using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_6_Library;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TotalFare = 500;

            Concession c = new Concession();
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age ");
            uint age = uint.Parse(Console.ReadLine());
            c.CalculateConcession(name,age);
            Console.Read();
        }
    }
}
