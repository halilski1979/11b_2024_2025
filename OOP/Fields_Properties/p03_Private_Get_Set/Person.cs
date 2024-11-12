using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03_Private_Get_Set
{
    internal class Person
    {
        // Полета
        private string fName;
        private string sName;
        private int age;

        // Конструктор за задаване на полетата при създаване на обект
        public Person(string firstName, string lastName, int age)
        {
            FName = firstName;
            SName = lastName;
            Age = age;
        }

        // Свойства
        public string FName
        {
            get { return fName; }
            private set { fName = value; } // Само вътрешно в класа може да се задава
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
                // Примерна валидация за възрастта
                if (value >= 0)
                    age = value;
            }

        }


    }
}
