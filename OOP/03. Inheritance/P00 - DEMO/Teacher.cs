using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00___DEMO
{
    internal class Teacher : Person
    {
        // Ново поле
        public string Subject { get; set; }

        // Конструктор
        public Teacher(string firstName, string lastName, int age, string subject)
            : base(firstName, lastName, age)
        {
            this.Subject = subject;
        }

        // Презаписване на метода DisplayInfo
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}. I am a Teacher,Subject:{Subject}");            
        }
    }
}
