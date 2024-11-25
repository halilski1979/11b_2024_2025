using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p17___Family
{
    internal class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }       
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

       //ИМПЛЕМЕНТИРАМЕ метод ToStraing()
        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }

    }
}