namespace P01_PersonFieldPropertie
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person p=new Person();
            p.FName = "Ivan";
            p.SName = "Ivanov";
            p.Age = 30;

            Console.WriteLine($"Name: {p.FName} {p.SName}, {p.Age} years old!");
        }
    }
}
