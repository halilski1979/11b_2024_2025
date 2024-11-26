using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00_Demo
{
    internal class Employee:Person
    {
        public string CompanyName { get; set; }

        public Employee(string fName, string sName, int age, string companyName)
            : base(fName, sName, age)
        {
            CompanyName = companyName;
        }

        public override string GetDetails()
        {
            return $"Employee: {fName} {sName}, Age: {age}, Company: {CompanyName}";
        }
    }
}
