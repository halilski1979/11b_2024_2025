namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {            
                     
            int sMax=int.MinValue;
            string winnerName = "";

            while (true) 
            {
                string name = Console.ReadLine();

                if (name=="Stop")
                {
                    break;
                }
                //Сбор от ASCCI код на името
                int s = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    s += name[i];
                }
                

                if (s > sMax)
                {
                  sMax = s;
                   winnerName= name;
                }

            }

            Console.WriteLine($"{winnerName}={sMax}");

        }
    }
}
