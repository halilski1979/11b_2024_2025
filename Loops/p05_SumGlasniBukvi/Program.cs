namespace p05_SumGlasniBukvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Напишете програма, която Прочита от потребителя текст, извежда сумата на гласните букви според таблицата по-долу: a=1 e=2 i=3 o=4 u=5 */

            string word=Console.ReadLine();
            int s = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]=='a')
                {
                    s += 1;
                }
                if (word[i] == 'e')
                {
                    s += 2;
                }
                if (word[i] == 'i')
                {
                    s += 3;
                }
                if (word[i] == 'o')
                {
                    s += 4;
                }
                if (word[i] == 'u')
                {
                    s += 5;
                }
            }
            Console.WriteLine(s);

        }
    }
}
