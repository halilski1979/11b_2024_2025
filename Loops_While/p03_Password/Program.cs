namespace p03_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                Console.Write("User: ");
                string user = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();


                if (counter == 3)
                {
                    Console.WriteLine("Error");
                    break; 
                }
                if (user == "Emil" && password=="1234")
                {
                    Console.WriteLine($"Hello,{user}. Welcome!");
                    break;
                }
                counter++;
            }
        }
    }
}
