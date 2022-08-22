
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

            int x = 0;
            string answer = "";
            showQuestion("how many finger do you have", " a)5", " b)10", " c) 30",
           " d) 1", "b");

            answer = Console.ReadLine();
            if (answer == "b)10")
            {
                x = x + 1;
            }
            showQuestion("how many days are in a year", " a)365", " b)364", " c) 356", " d) 305", "a");
       
    answer = Console.ReadLine();
            if (answer == "a)365")
            {
                x = x + 1;
            }
            showQuestion("what should you do at a stop sign?", " a)go", " b)get out ", " c) stop", " d) nothing", "c");
       
 answer = Console.ReadLine();
            if (answer == "c)stop")
            {
                x = x + 1;
            }
            Console.WriteLine("you got {0} wrong", x);
            showQuestion("What is 1+1?", " a)1", " b)2", " c) 0", " d) 6", "b");
            Console.ReadKey();
        }
        public static void showQuestion(string question,
        string answer1,
        string answer2,
        string answer3,
        string answer4,
        string correct)

        {
            Console.WriteLine(question);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            string answer = Console.ReadLine();
            if (answer.Equals(correct))
            {
                Console.WriteLine("you got it right");
            }
        }
    }

}