using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14___Humans_Matura
{
    internal class Student:Human
    {
        public Student(string firstName, string lastName, int age, double grade)
           : base(firstName, lastName, age)
        {
            this.Grade = grade;
        }
       
        
        
        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} years old, grade: {grade:f2}";
        }
    }
}
