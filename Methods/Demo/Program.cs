namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFull();
        }

         static void PrintFull()
        {
            Header();
            Middle();
            Footer();
        }

        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void Middle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© IT Kariera");
        }

    }
}
