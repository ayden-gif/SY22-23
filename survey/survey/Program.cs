using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace survey
{
    internal class Program
    {
        static void Main(string[] args)
   
        {
            int x=0;

            string answer = ""; 
                
            Console.WriteLine("how many fingers do you have");

            Console.WriteLine("5,10,30");

            answer =Console.ReadLine();
            if (answer == "5")
            {
                x = x + 1;
            }
                Console.WriteLine("how many days are in a year");

            Console.WriteLine(" a. 365 days, b. 364 days,c. 356 days ");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                x = x + 1;
            }
            Console.WriteLine("what should you do at a red sign");

            Console.WriteLine("a. stop b. go c. get out of car");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                x = x + 1;
            }
            Console.WriteLine("you got {0} correct",x);
            Console.ReadKey();
        }
    }
}
