namespace p01_Numbers_Ending_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Числа, завършващи на 7
            for (int i = 1; i <= 100; i++)
            {
               if (i %10== 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
