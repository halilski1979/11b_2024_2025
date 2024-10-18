namespace p02_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)             
            {                
                Console.WriteLine(i);
                i++;

                if (i==100)
                {
                    break;
                }
            }

        }
    }
}
