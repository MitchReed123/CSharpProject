using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageList = new List<string>();

            ageList.Add("20");
            ageList.Add("34");
            ageList.Add("45");
            ageList.Add("55");
            ageList.Add("90");
            ageList.Add("23");
            ageList.Add("32");
            ageList.Add("46");
            ageList.Add("24");
            ageList.Add("78");

            for (var i = 0; i < ageList.Count; i++)
            {
                Console.WriteLine(ageList[i]);
            }

            for (var i = 0; i < ageList.Count; i++)
            {
                Console.WriteLine("Paul's phone number is {0}", ageList.ElementAt(4));
            }
        }

    }
}
