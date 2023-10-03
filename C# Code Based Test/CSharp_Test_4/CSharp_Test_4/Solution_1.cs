using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_Test_4
{
    class Solution_1
    {
        static void Main()
        {
            // file path
            string filePath = @"D:\Assignment\C# Code Based Test\CSharp_Test_4\sapmple_test_4.txt";

            // message to text file
            string textToAppend = "Today is C sharp code based Test_4";

            // for appending
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
               
                writer.WriteLine(textToAppend);

               
                writer.Close();
            }

            Console.WriteLine("File Created and Text has been appended to the file.");
            Console.ReadLine();
        }
    }

}