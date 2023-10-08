// Test Based Code 3 Question 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Test_3
{
    class Box
    {
       public  double Length;
        public double  Breadth;
        public Box(double length, double breadth)
        {
            this.Length = length;
            this.Breadth = breadth;

        }
        public static Box operator +(Box box1, Box box2)
        {
            double sumLength = box1.Length + box2.Length;
            double sumBreadth = box1.Breadth + box2.Breadth;

            return new Box(sumLength, sumBreadth);
        }

        public void Display_3object()
        {
            Console.WriteLine("Length of 3rd Box is: {0}",Length);
            Console.WriteLine("Breadth of 3rd Box is: {0}",Breadth);
        }

    }

    class Test
    {
        public static void Main()
        {
            Console.WriteLine("............Length and Breadth For Box 1............ ");
            Console.WriteLine("Enter the length of box 1 ");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length is : " + length1);
            Console.WriteLine();
            Console.WriteLine("Enter the Breadth of box 1 ");
            double breadth1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Breadth is : " + breadth1);
               

            Console.WriteLine("\n............Length and Breadth For Box 2......... ");
            Console.WriteLine("Enter the length of box 2 ");
            double length2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length is : " + length2);
            Console.WriteLine();
            Console.WriteLine("Enter the Breadth of box 2 ");
            double breadth2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Breadth is : " + breadth2);



            Box b1 = new Box(length1,breadth1);
            Box b2 = new Box(length2, breadth2);
            Box b3 = b1 + b2;

            Console.WriteLine("\n................Length and Breadth of Box 3 is: ...............");
            b3.Display_3object();

            Console.ReadLine();


        }
    }
}
