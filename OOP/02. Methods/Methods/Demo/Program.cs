namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ivan", "Ivanov", 44);
            Console.WriteLine(p.GetFullName()); 
        }
    }
}
