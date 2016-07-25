using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
       public enum Gender { Uknown, Male, Female};
    public class Properties
    {
        private string _Name;
        private string _Age;
        private Gender _Gender;

        public string Name { get;  set; }
        public string Age { get; set; }
        public Gender Gender { get; set; }

        public Properties(string name, Gender gender, string age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public void WhoYouAre(string Name, string age, Gender Gender)
        {
            Console.WriteLine($"Hello {Name}, You are {age} years young, and you are {Gender}");
        }
    }
    }


