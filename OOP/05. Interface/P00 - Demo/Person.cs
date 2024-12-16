using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace P00___Demo
{
    internal class Person : IPerson,IWorker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string JobTitle { get; set; }


        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Person(string firstName, string lastName, int age, string jobTitle)
        : this(firstName, lastName, age) // Извиква първия конструктор
        {
            JobTitle = jobTitle;
        }



        public void DisplayInfo()
        {
            Console.WriteLine($"My name is {this.FirstName} {this.LastName}. I am {this.Age}");
        }

        public override string ToString()
        {
            return $"My name is {this.FirstName} {this.LastName}. I am {this.Age}";
        }

        public void Work()
        {
            Console.WriteLine($"{FirstName} is working as a {JobTitle}.");
        }
    }
}
