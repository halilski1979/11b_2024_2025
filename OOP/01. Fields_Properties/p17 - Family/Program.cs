namespace p17___Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family ivanovi = new Family();

            int br = int.Parse(Console.ReadLine());

            for (int i = 0; i < br; i++)
            {
              var cmd=Console.ReadLine().Split(' ').ToList();
              string name=cmd[0];
              int age=int.Parse(cmd[1]);
              Person p=new Person(name,age);
              ivanovi.AddMember(p);
            }

            Console.WriteLine(ivanovi.GetOldestMember());
        }

    }
    
}
