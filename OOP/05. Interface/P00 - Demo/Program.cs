namespace P00___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ivan","Ivanov",25);
            IPerson p2 = new Person("Petar", "Georgiev", 45);

            List<IPerson> people = new List<IPerson>();
            people.Add(p1);
            people.Add(p2);

            Console.WriteLine(string.Join("! \n",people));
            p1.Work();
        }
    }
}
