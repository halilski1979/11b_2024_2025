using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P00_Demo
{
    internal class Student:Person
    {
        public string SchoolName { get; set; }

        public Student(string fName, string sName, int age, string schoolName)
            : base(fName, sName, age)
        {
            SchoolName = schoolName;
        }

        public override string GetDetails()
        {
            return $"Student: {fName} {sName}, Age: {age}, School: {SchoolName}";
        }
    }
}
