namespace p02_PrivateMethods_DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ivan","Ivanov",35);

            person.DisplayInfo();
            Console.WriteLine("===========");
            Console.WriteLine(person.GetFullName());

        }
    }
}
