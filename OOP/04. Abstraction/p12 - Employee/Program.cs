namespace p12___Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("001", "John Smith", "123 Main St", "Manager", "Sales");
            ContractEmployee contractEmployee = new ContractEmployee("002", "Jane Doe", "456 Elm St", "Website Redesign", "IT");

            Console.WriteLine("--- Full Time Employee ---");
            fullTimeEmployee.Show();
            Console.WriteLine($"Salary: {fullTimeEmployee.CalculateSalary(160)}\nDepartment: {fullTimeEmployee.GetDepartment()}");

            Console.WriteLine("\n--- Contract Employee ---");
            contractEmployee.Show();
            Console.WriteLine($"Salary: {contractEmployee.CalculateSalary(120)}\nDepartment: {contractEmployee.GetDepartment()}");
        }
    }
}
