using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var dcotors =
                new List<string>
                {
                    "Mitch",
                    "Dan",
                    "Steve",
                    "Joe",
                    "Phillip",
                };

            foreach (var name in dcotors)
            {
                Console.WriteLine($"Name: {name}");
            }
        }
    }
}
