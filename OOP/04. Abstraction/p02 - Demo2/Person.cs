using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02___Demo2
{
    abstract class Person
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }

        protected Person(string fName, string sName, int age)
        {
            FName = fName;
            SName = sName;
            Age = age;
        }

       public void GetName()
        {
            Console.WriteLine($"My  name is {this.FName} {this.SName}");
        }

        public abstract void FullInfo();

    }
}
