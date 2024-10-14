namespace p03_Sum_ChetniChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сбор на четни числа 1..10
            int s = 0;

            for (int i = 0; i < 11; i++)
            {
                if (i%2==0)
                {
                    // s = s + i;
                    s += i;
                }  
            }
            Console.WriteLine(s);
        }
    }
}
