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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name cannot be null or empty.");
                if (value.Length < 2 || value.Length > 50)
                    throw new ArgumentException("First name must be between 2 and 50 characters.");
                fName = value;
            }
        }

        public string SName
        {
            get { return sName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Second name cannot be null or empty.");
                if (value.Length < 2 || value.Length > 50)
                    throw new ArgumentException("Second name must be between 2 and 50 characters.");
                sName = value;
            }
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentException("Age must be between 0 and 120.");
                age = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative.");
                if (value > 1_000_000)
                    throw new ArgumentException("Salary exceeds maximum allowed value.");
                salary = value;
            }
        }

        public string City
        {
            get { return city; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("City cannot be null or empty.");
                city = value;
            }
        }

        // Конструктор
        public Person(string fName, string sName, int age, decimal salary, string city)
        {
            FName = fName; // През свойствата се прилагат валидациите
            SName = sName;
            Age = age;
            Salary = salary;
            City = city;
        }

        // Показване на информация за обекта
        public override string ToString()
        {
            return $"Name: {FName} {SName}, Age: {Age}, Salary: {Salary:C}, City: {City}";
        }
    }
}
