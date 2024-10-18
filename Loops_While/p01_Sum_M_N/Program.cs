namespace p01_Sum_M_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m=int.Parse(Console.ReadLine());//Долна граница
            int n=int.Parse(Console.ReadLine());//Горна граница
            int s = 0;

            while (m <=n )
            {
                s += m;
                m++;
            }
            Console.WriteLine(s);

        }
    }
}
