namespace p13___Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // BaseEmployee employee = new BaseEmployee("1","Ivan","Adres1");

           List<BaseEmployee> employees = new List<BaseEmployee>();
            
            
            BaseEmployee employee1 = new ContractEmployee("1","Ivan Ivanov","Adres1","Sekretar","Schetovodstvo");
            employees.Add(employee1);

            Console.WriteLine(employee1.GetDepartment());
            Console.WriteLine(employee1.CalculateSalary(80));
            employee1.Show();


            BaseEmployee employee2 = new FullTimeEmployee("2","Petar Petrov","Adres2","Worker","Priem");
            employees.Add(employee2);

            Console.WriteLine(employee2.GetDepartment());
            Console.WriteLine(employee2.CalculateSalary(80));
            employee2.Show();

        }
    }
}
