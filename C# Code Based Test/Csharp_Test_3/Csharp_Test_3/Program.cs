// Test Based Code 3 Question 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Test_3
{
    class Cricket{
        public void  Pointscalculation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];
            int sum = 0;
            int matchcount = 1;

            foreach(int i in scores)
            {
                Console.WriteLine("Enter the score of Match " + matchcount);
                scores[i] = Convert.ToInt32(Console.ReadLine());
                sum += scores[i];
                matchcount++;
            }

            double Average = sum / no_of_matches;

            Console.WriteLine("Sum of score of {0} Match is : {1} ", no_of_matches,sum);
            Console.WriteLine("Average of score of {0} Match is : {1} ", no_of_matches, Average);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the no of match ");
            int no_of_matches = Convert.ToInt32(Console.ReadLine());

            Cricket ck = new Cricket();
            ck.Pointscalculation(no_of_matches);
            Console.ReadLine();
        }
    }
}
