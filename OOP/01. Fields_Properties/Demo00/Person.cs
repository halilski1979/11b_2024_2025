using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo00
{
    internal class Person
    {
        public Person(string fName, string sName, int age, double salary)
        {
            FName = fName;
            SName = sName;
            Age = age;
            Salary = salary;
        }

        public Person()
        {

        }

        public string FName { get; set; }
        public string SName  { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }


       public void Print()
        {
            Console.WriteLine($"Kazvam se {FName} {SName} , {Age} godini, {Salary} lv.");
        }      

        
        public override string ToString()
        {
            return $"My name is {FName} {SName} , {Age} age, {Salary} lv.";
        }


    }
}
