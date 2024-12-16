using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13___Employee
{
    abstract class BaseEmployee
    {

        public string employeeID { get;private set; }
        public string employeeName { get;private set; }
        public string employeeAdress { get;private set; }
        
        protected BaseEmployee(string employeeID, string employeeName, string employeeAdress)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAdress = employeeAdress;
        }

      public virtual void Show()
        {
            Console.WriteLine($"ID: {this.employeeID}. {this.employeeName}. {this.employeeAdress}");
        }
      public abstract double CalculateSalary(int workingHours);

      public abstract string GetDepartment();
    }
}
