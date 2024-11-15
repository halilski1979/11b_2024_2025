using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01___ConstruktorsDemo
{
    internal class Person
    {
        // Частни полета на класа
        private string fName;
        private string sName;
        private int age;

        // Свойства за достъп до частните полета
        public string FName
        {
            get { return fName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    fName = value;
                else
                    fName = "UnknownFirstName";
            }
        }

        public string SName
        {
            get { return sName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    sName = value;
                else
                    sName = "UnknownSecondName";
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    age = 0;
            }
        }

        // 1. Конструктор по подразбиране
        public Person()
        {
            FName = "DefaultFirstName";
            SName = "DefaultFirstName";
            Age = 0;            
        }

        // 2. Параметризиран конструктор
        public Person(string firstName, string lastName, int personAge)
        {
            FName = firstName;
            SName = lastName;
            Age = personAge;
            Console.WriteLine($"Създаден е човек: {FName} {SName}, възраст: {Age}.");
        }
       
    }

   
}
