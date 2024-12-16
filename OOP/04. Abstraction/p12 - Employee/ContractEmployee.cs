using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12___Employee
{
    internal class ContractEmployee:BaseEmployee
    {
        public string EmployeeTask { get; private set; }
        public string EmployeeDepartment { get; private set; }

        public ContractEmployee(string employeeID, string employeeName, string employeeAddress, string employeeTask, string employeeDepartment)
            : base(employeeID, employeeName, employeeAddress)
        {
            EmployeeTask = employeeTask;
            EmployeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Task: {EmployeeTask}");
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20.0;
        }

        public override string GetDepartment()
        {
            return EmployeeDepartment;
        }
    }
}
}
