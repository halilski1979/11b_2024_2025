using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14___Humans_Matura
{
    internal class Human
    {
        private string firstName;
        private string lastName;
        private int age;

        protected Human(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} years old ";
        }
    }
}
