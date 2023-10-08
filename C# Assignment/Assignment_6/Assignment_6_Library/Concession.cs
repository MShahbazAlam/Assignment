using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Library
{
    public class Concession
    {
        static int Fare= 500;
        

        public void CalculateConcession(string name,uint age)
        {
            
            if(age <=5)
            {   
                Console.WriteLine("Little champs- Free Ticket  \nName : {0}  \nAge : {1}",name,age);
            }
            else if(age > 60){

                double totalFare = (Fare * 30) / 100;
                double discountedFare = Fare - totalFare;
                Console.WriteLine("Senior Citizen!!!   \nTotal Fare is : {0}  \nName : {1} \nAge : {2} ", discountedFare,name,age);

            }
            else
            {
                Console.WriteLine("Ticket Booked!!   \nFare is : {0} \nName : {1} \nAge : {2}", Fare,name,age);
            }
            

        }
    }
}
