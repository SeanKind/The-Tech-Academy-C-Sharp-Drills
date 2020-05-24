using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_22_Generic_types
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee<string> stringThings = new Employee<string>();
            Employee<int> intThings = new Employee<int>();

            stringThings.things.Add("test");
            stringThings.things.Add("test2");
            stringThings.things.Add("test3");
            

            intThings.things.Add(5);
            intThings.things.Add(10);
            intThings.things.Add(15);



            foreach (string item in stringThings.things)
            {
                Console.WriteLine(item + " ");
            }
            foreach (int item in intThings.things)
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadLine();




        }
    }
}
