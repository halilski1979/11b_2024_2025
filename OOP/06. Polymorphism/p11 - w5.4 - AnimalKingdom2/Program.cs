namespace p11___w5._4___AnimalKingdom2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer(new Cat());
            trainer.Make();
            Trainer trainer1 = new Trainer(new Dog());
            trainer1.Make();

        }
    }
}
