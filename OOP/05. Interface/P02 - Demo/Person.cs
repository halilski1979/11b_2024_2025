using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02___Demo
{
    internal class Person : IWorker, IPerson,IStudent
    {
        public Person(string fName, string sName, int age, string jobTitle)
        {
            FName = fName;
            SName = sName;
            Age = age;
            JobTitle = jobTitle;
        }

      

        public string FName { get ; set ; }
        public string SName { get ; set ; }
        public int Age { get ; set ; }
        public string FNumber { get; set; }
        public string JobTitle { get; set; }
       

        public void DisplayInfo()
        {
            Console.WriteLine($"My name is {this.FName} {this.SName}. I am {this.Age} years old. My job is {this.JobTitle}");
        }

        public void Study()
        {
            Console.WriteLine($"I am studet with number {this.FNumber}");
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
