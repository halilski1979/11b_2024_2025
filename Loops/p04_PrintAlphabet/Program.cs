namespace p04_PrintAlphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Кастване  - преминаване от един тип в друг

            for (char i = 'A'; i <= 'Y'; i++) 
            {
                Console.WriteLine($"{i} {(int)(i)}");
            }

            Console.WriteLine("=========");

            for (int j = 0; j <=255 ; j++)
            {
                Console.WriteLine($"{j} => {(char)(j)}");
            }

        }
    }
}
