using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12___Employee
{
    abstract class BaseEmployee
    {
        public string EmployeeID { get; private set; }
        public string EmployeeName { get; private set; }
        public string EmployeeAddress { get; private set; }

        public BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            EmployeeAddress = employeeAddress;
        }

        public virtual void Show()
        {
            Console.WriteLine($"ID: {EmployeeID}\nName: {EmployeeName}\nAddress: {EmployeeAddress}");
        }

        public abstract double CalculateSalary(int workingHours);
        public abstract string GetDepartment();
    }
}
