namespace p02_Sum_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сбор на числа от 1 до 10

            int s = 0;
            for (int i = 0; i < 11; i++) 
            {
                s =s+i;
            }
            Console.WriteLine(s);
        }
    }
}
