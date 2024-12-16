using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12___Employee
{
    internal class FullTimeEmployee : BaseEmployee
    {
        public string EmployeePosition { get; private set; }
        public string EmployeeDepartment { get; private set; }

        public FullTimeEmployee(string employeeID, string employeeName, string employeeAddress, string employeePosition, string employeeDepartment)
            : base(employeeID, employeeName, employeeAddress)
        {
            EmployeePosition = employeePosition;
            EmployeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {EmployeePosition}\nDepartment: {EmployeeDepartment}");
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80;
        }

        public override string GetDepartment()
        {
            return EmployeeDepartment;
        }
    }
}
