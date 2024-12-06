using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14___Humans_Matura
{
    internal class Worker:Human
    {
        private double wage;
        private int workHours;
        public Worker(string firstName, string lastName, int age, double wage, int workHours)
            : base(firstName, lastName, age)
        {
            this.Wage = wage;
            this.WorkHours = workHours;
        }
        public double Wage
        {
            get { return wage; }
            private set { wage = value; }
        }
        public int WorkHours
        {
            get { return workHours; }
            private set { workHours = value; }
        }
        //Metod
      
        
        private double Salary()
        {
            return Wage * WorkHours;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}, {this.Age} years old, salary: ${Salary():f2}.";
        }
    }
}
