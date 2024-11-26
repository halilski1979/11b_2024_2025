using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_Demo
{
    abstract class Person
    {
        // Полета
        protected string fName;
        protected string sName;
        protected int age;

        // Конструктор
        public Person(string fName, string sName, int age)
        {
            this.fName = fName;
            this.sName = sName;
            this.age = age;
        }

        // Абстрактен метод
        public abstract string GetDetails();

        // Общ метод
        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {fName} {sName}");
        }
    }
}
