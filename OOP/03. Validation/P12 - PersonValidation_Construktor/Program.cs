using System.Diagnostics.Metrics;

namespace P12___PersonValidation_Construktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person
                (
                    cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    double.Parse(cmdArgs[3])
                );
                persons.Add(person);
            }

            foreach (var item in persons)
            {
                item.IncreaseSalary(20);
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(Person.counter);
        }
    }
}
