using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13___Employee
{
    internal class FullTimeEmployee : BaseEmployee
    {
        public string Position { get;private set; }
        public string Department { get;private set; }

        public FullTimeEmployee(string employeeID, string employeeName, string employeeAdress, string position, string department) : base(employeeID, employeeName, employeeAdress)
        {
            this.Position = position;
            this.Department = department;
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80;
        }

        public override string GetDepartment()
        {
           return Department;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position {this.Position}. Department: {this.Department}");

        }
    }
}
