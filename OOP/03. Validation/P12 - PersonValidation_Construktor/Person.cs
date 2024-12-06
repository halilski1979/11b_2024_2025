using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12___PersonValidation_Construktor
{
    internal class Person
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        private static int counter;
        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }





        public Person(string fName, string sName, int age, double salary)
        {
            if (fName.Length<3)
            {
                throw new ArgumentException("First Name cannot be less than 3 symbols");
            }

            if (sName.Length < 3)
            {
                throw new ArgumentException("Second Name cannot be less than 3 symbols");
            }

            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative!");
            }
            if (salary < 500)
            {
                throw new ArgumentException("Salary cannot be less than 500 lv.");
            }
            FName = fName;
            SName = sName;
            Age = age;
            Salary = salary;
            counter++;
        }


       

        public void IncreaseSalary(double bonus)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * bonus / 100;
            }
            else
            {
                this.Salary += this.Salary * bonus / 200;
            }
        }

        public override string ToString()
        {
            return $"{FName} {SName}, {Age} years old, {Salary} lv.";
        }


    }
}
