using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Person
    {
        // Полета
        private string fName;
        private string sName;
        private int age;

        // Свойства
        public string FName
        {
            get { return fName; }
            private set { fName = value; }
        }
        public string SName
        {
            get { return sName; }
            private set { sName = value; }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value >= 0)
                    age = value;
            }
        }

        // Конструктор
        public Person(string firstName, string lastName, int age)
        {
            FName = firstName;
            SName = lastName;
            Age = age;
        }

        // Метод за пълното име
        public string GetFullName()
        {
            return $"{FName} {SName}";
        }

        // Метод за проверка на пълнолетието
        public bool IsAdult()
        {
            return Age >= 18;
        }

        // Метод за увеличаване на възрастта с една година
        public void IncreaseAge()
        {
            Age += 1;
        }
    }
}
