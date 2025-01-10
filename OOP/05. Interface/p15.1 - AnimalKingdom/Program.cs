namespace p15._1___AnimalKingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Animal> animals = new List<Animal>();

          Animal dog=new Dog("Rex",11);
            Animal cat = new Cat("Tiny", 22);

            animals.Add(dog);
            animals.Add(cat);

            Console.WriteLine(cat.MakeNoise());
            Console.WriteLine(cat.MakeTrick()); 
        }
    }
}
