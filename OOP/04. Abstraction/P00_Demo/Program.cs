namespace P00_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Създаване на обекти от конкретни класове
            Student student = new Student("John", "Doe", 20, "Harvard University");
            Employee employee = new Employee("Jane", "Smith", 30, "TechCorp");

            // Извикване на методи
            student.DisplayFullName();
            Console.WriteLine(student.GetDetails());

            employee.DisplayFullName();
            Console.WriteLine(employee.GetDetails());

            Person person = new Person("John", "Doe", 20);
        }
    }
}
