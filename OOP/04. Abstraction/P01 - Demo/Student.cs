using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01___Demo
{
    internal class Student : Person
    {

        public double Grade { get; set; }
        public Student(string fName, string sName, int age, double grade) : base(fName, sName, age)
        {
            Grade = grade;
        }

        public override void GetFullInfo()
        {
            Console.WriteLine($"My name is {this.FName} {this.SName}. I am {this.Age} years old. My grade is {this.Grade} ");
        }
    }
}
