using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How is your day going?(1-5 1 being the worst 5 being the best)");

            string DayGoing = Console.ReadLine();
            if (DayGoing == "5")
            {
                Console.WriteLine("I'm glad your day is going great!");
            }
            if (DayGoing == "4")
            {
                Console.WriteLine("I'm glad your day is going good.");
            }
            if (DayGoing == "3")
            {
                Console.WriteLine("It sucks that your day is just Ok");
            }
            if (DayGoing == "2")
            {
                Console.WriteLine("Why is your day going so bad?");
            }
            if (DayGoing == "1")
            {
                Console.WriteLine("Dang, sounds like you need to take the rest of they day off");
            }
            else
            {
                Console.WriteLine("I do not understand what you put in, please come back later");
            }
        }
    }
}
