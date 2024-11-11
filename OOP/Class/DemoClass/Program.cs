namespace DemoClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.fName = "Ivan";
            p1.sName = "Ivanov";
            p1.age = 22;

            Person p2 = new Person();
            p2.fName = "Petar";
            p2.sName = "Petrov";
            p2.age = 23;

            Console.WriteLine($"Name: {p1.fName} {p1.sName}, {p1.age} years old!");
            Console.WriteLine($"Name: {p2.fName} {p2.sName}, {p2.age} years old!");

        }
    }
}
