using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05___Validation
{
    internal class Person
    {
        // Полета
        private string fName;
        private string sName;
        private int age;
        private decimal salary;
        private string city;

        // Свойства
        public string FName
        {
            get { return fName; }
            private set
            {               
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Firts name cannot be null or empty!");
                }

                if (value.Length<2 || value.Length > 50)
                {
                    throw new ArgumentException("First name must be >2 and <50 symbols.");
                } 
                
                fName = value;
            }
        }
        public string SName
        {
            get { return sName; }
            private set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Second name canot be null or empry!");
                }
                sName = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value<0 || value>100)
                {
                    throw new ArgumentException("Age cannot be negative or more than 100!");
                }
                age = value;
            }
        }
        public decimal Salary
        {
            get { return salary; }
            private set
            {
                if (value < 1000 || value > 2000)
                {
                    throw new ArgumentException("Age cannot be negative or more than 100!");
                }
                salary = value;
            }
        }
        public string City
        {
            get { return city; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Firts name cannot be null or empty!");
                }

                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentException("First name must be >2 and <50 symbols.");
                }
                city = value;
            }
        }

        // Конструктор
        public Person(string fName, string sName, int age, decimal salary, string city)
        {
           this.FName = fName; // През свойствата се прилагат валидациите
            this.SName = sName;
            this.Age = age;
            this.Salary = salary;
            this.City = city;
        }        

        // Показване на информация за обекта
        public override string ToString()
        {
            return $"Name: {FName} {SName}, Age: {Age}, Salary: {Salary:C}, City: {City}";
        }
    }
}
