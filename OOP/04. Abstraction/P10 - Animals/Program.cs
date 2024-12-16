namespace P10___Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Animal> animals = new List<Animal>();

            Lion l = new Lion("Leo", 5);
            Parrot p = new Parrot("Polly", 2);

            animals.Add(l);
            animals.Add(p);
            

            // Извикваме метода MakeSound() за всяко животно
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} is {animal.Age} years old.");
                animal.MakeSound();
            }
        }
    }
}
