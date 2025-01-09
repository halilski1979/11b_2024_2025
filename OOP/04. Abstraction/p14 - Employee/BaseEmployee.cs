using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14___Employee
{
    abstract class BaseEmployee
    {
        public string employeeID { get; private set; }
        public string employeeName { get; private set; }
        public string employeeAddress { get; private set; }


        protected BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
        }

        public virtual void Show()
        {
            Console.WriteLine($"ID: {this.employeeID}, Name: {this.employeeName}. Adress:{this.employeeAddress}");
        }

        public abstract double CalculateSalary(int workingHours);
        public abstract string GetDepartment();
       

    }
}
