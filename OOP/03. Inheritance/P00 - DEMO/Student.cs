using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00___DEMO
{
    internal class Student : Person
    {

        // Ново поле
        public string Grade { get; set; }

        // Конструктор, който използва базовия конструктор
        public Student(string firstName, string lastName, int age, string grade)
            : base(firstName, lastName, age) // Извиква конструктора на базовия клас
        {
            this.Grade = grade;
        }

        // Презаписване (override) на метода DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Извиква метода от базовия клас
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}
