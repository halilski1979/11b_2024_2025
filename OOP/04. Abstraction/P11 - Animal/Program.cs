namespace P11___Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Animal> animals = new List<Animal>();

            
            Console.Write("Enter the number of animals: ");
            int n = int.Parse(Console.ReadLine());

           
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for animal {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());
                Console.Write("Habitat: ");
                string habitat = Console.ReadLine();

                
                Console.Write("Enter the type of animal (Lion, Parrot, Elephant): ");
                string type = Console.ReadLine().ToLower();

                
                if (type =="lion")
                {
                    Animal animall = new Lion(name, age, weight, habitat);
                    animals.Add(animall);
                }
                else if (type == "parrot")
                {
                    Animal animall = new Parrot(name, age, weight, habitat);
                    animals.Add(animall);
                }
                else if (type == "elephant")
                {
                    Animal animall = new Elephant(name, age, weight, habitat);
                    animals.Add(animall);
                }
                else
                {
                    throw new Exception("Invalid animal type!");                   
                }
               

            }

           
            foreach (var animal in animals)
            {
               
                Console.WriteLine($"{animal.Name}, a {animal.Type}, is {animal.Age} years old and weighs {animal.Weight} kg.");
                Console.WriteLine($"Habitat: {animal.Habitat}");
                animal.MakeSound();
                animal.Feed();
                animal.Sleep();
                Console.WriteLine();
            }
        }
    }
}
