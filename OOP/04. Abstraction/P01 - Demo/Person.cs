using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01___Demo
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


        public abstract void GetFullInfo();

        public void GetName()
        {
            Console.WriteLine($"Name: {this.FName} {this.SName}!");
        }



    }
}
