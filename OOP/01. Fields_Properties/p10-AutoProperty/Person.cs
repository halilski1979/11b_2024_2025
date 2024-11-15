using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_AutoProperty
{
    internal class Person
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public void GetAll()
        {
            Console.WriteLine($"My name is {FName} {SName}. " +
                $"I am {Age} years old. My salary is {Salary}");
        }
        public string GetFullName()
        {
            return $"My name is {FName} {SName}!";
        }
        public void IncreaseAge()
            { 
                Age += 1; 
            }
    }
}
