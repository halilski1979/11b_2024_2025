namespace P10_PersonDataValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           Person p=new Person("Ivan","Ivanov",23,20000);

            Console.WriteLine(p);
            p.LastName = "Petrov";

            Console.WriteLine(p);
        }
    }
}
