using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00___DEMO
{
    internal class Person
    {
        // Полета
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Конструктор
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Метод за представяне на информация
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
        }
    }
}
