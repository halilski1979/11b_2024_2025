using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01___Demo1
{
    internal class Person : IPerson, IWorker
    {
        public Person(string fName, string sName, int age, string job)
        {
            FName = fName;
            SName = sName;
            Age = age;
            Job = job;
        }

        public string FName { get ; set ; }
        public string SName { get ; set ; }
        public int Age { get ; set ; }
        public string Job { get ; set ; }

        public void GetInfo()
        {
            Console.WriteLine($"My name is {this.FName} {this.SName}! I am {Age} years old.");
        }

        public double Salary(double moneyPerHour, int hours)
        {
            return moneyPerHour * hours;
        }

        public override string ToString()
        {
            return $"My name is {this.FName} {this.SName}! I am {Age} years old.Salary: {Salary(12,22)}";
        }
    }
}
