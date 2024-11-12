using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace p02_PrivateMethods_DEMO
{
    internal class Person
    {
        private string fName;
        private string sName;
        private int age;

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


        public Person(string firstName, string lastName, int age)
        {
            FName = firstName;
            SName = lastName;
            Age = age;
        }

        // Публичен метод
        public void DisplayInfo()
        {
            Console.WriteLine(GetPersonInfo());
        }

        // Пример за private метод
        private string GetPersonInfo()
        {
            return $"Name: {GetFullName()}, Age: {age}";
        }

        // Метод за пълно име
        public string GetFullName()
        {
            return $"{FName} {SName}";
        }

    }
}
