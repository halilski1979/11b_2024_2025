﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14___Employee
{
    internal class FullTimeEmployee : BaseEmployee
    {
        public string employeePosition { get;private set; }
        public string employeeDepartment { get; set; }

        public FullTimeEmployee(string employeeID, string employeeName, string employeeAddress, string employeePosition, string employeeDepartment) : base(employeeID, employeeName, employeeAddress)
        {
            this.employeePosition = employeePosition;
            this.employeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {this.employeePosition}");
            Console.WriteLine($"Otdel: {this.employeeDepartment}");
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }
    }
}
