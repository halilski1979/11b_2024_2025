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
        public string fName;
        public string sName;
        public int age;

        // Конструктор
        public Person(string fName, string sName, int age)
        {
            this.fName = fName;
            this.sName = sName;
            this.age = age;
        }

        
        //•	Деклариран е без тяло в абстрактен клас.
        //•Трябва задължително да бъде имплементиран в наследяващия клас.
        public abstract string GetDetails();

        
        
        // Общ метод
        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {fName} {sName}");
        }
    }
}
