using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_11_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            //Asks user for input and saves it. Then it prints to the console what they've entered
            //string[] userText = new string[3];
            
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Please enter a name to be saved: ");
            //    userText[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(userText[i]);
            //}
            //Console.ReadLine();


            ////Infinte loop
            //for (int i = 1; i > 0; i++)
            //{
            //    Console.WriteLine("Loooooop");
            //}


            ////Fixing the infinite loop, and < and <= operator determining whether to continue iterating 
            //for (int i = 0; i <= 1; i++)
            //{
            //    Console.WriteLine("We've fixed the loop!");
            //}

            //User entering values to be searched in a list and print the corresponding index. Informs the user if there is no matching value in the list, and exits the loop if 
            //a match has been found
            List<string> cars = new List<string>() { "Mustang", "Cobra", "Ferrari" };
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("Please enter a vehicle");
                string userValue = Console.ReadLine();
                if (userValue == cars[i])
                {
                    Console.WriteLine(i);
                    break;
                }
                if (userValue != cars[i])
                {
                    Console.WriteLine("That vehicle is not in the list.");
                }
            }










            Console.ReadLine();
        }
    }
}
