namespace p16___Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Family  petrovi = new Family();
           int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
               var cmd = Console.ReadLine().Split(' ').ToList();

                string name=cmd[0];
                int age=int.Parse(cmd[1]);

                Person p = new Person(name, age);
                petrovi.AddMember(p);
            }
            petrovi.Print();
            petrovi.SortName();
            petrovi.Print();

            Console.WriteLine(petrovi.GetOldestMember()); 



        }
    }
}
