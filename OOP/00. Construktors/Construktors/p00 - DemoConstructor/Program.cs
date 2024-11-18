namespace p00___DemoConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person p = new Person("Halil","Dospatliyki",25,3000);
            Person p1 = new Person();
            Person p2 = new Person("Ivan","Ivanov");
            Person p3 = new Person("Leo","Messi",36);

            Console.WriteLine(p);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
           
        }
    }
}
