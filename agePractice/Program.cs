using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");

            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 0 && userAge <= 2)

            {
                Console.WriteLine("Still in mama\'s arms!");

            }
            else if (userAge >= 3 && userAge <= 4)   //(userAge = 3 || userAge = 4) The else if allows for another condition

            {
                Console.WriteLine("PreSchool Maniac");

            }

            else if (userAge >= 5 && userAge <= 11)

            {
                Console.WriteLine("Elementary School");
            }

            else if (userAge >= 12 && userAge <= 14)

            {
                Console.WriteLine("Middle School");
            }

            else if (userAge >= 15 && userAge <= 18)
            {
                Console.WriteLine("High School");
            }

            else if (userAge >=19 && userAge <=22)

            {
                Console.WriteLine("College");
            }
            
            else if (userAge >=23 && userAge <=65)

            {
                Console.WriteLine("You are working for the man");
            }

            else if (userAge >=66 && userAge <=100)
                            {
                Console.WriteLine("The Golden Years");
            }
                
             else if (userAge < 0 || userAge > 100)                    
                    {
                Console.WriteLine("This program is for humans!!");
                    }

            Console.ReadLine();
        }
    }

}