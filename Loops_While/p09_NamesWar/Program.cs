namespace p09_NamesWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която изчислява ASCII стойността на няколко имена, като името с най-голяма стойност е победител. Стойността на името се изчислява като съберем ASCII стойностите на всички букви, от които се състои то. От конзолата ще се четат имена до получаването на команда „STOP“, след което трябва да се изпише:  
"Winner is {името на победителя} – {стойността на името му}!". */

                        
            string winnerName = "";
            int maxScore = 0;

            while (true)
            {
                string input = Console.ReadLine();

               
                if (input == "STOP")
                    break;

               
                int currentScore = 0;
                foreach (char letter in input)
                {
                    currentScore += (int)letter;
                }

                if (currentScore > maxScore)
                {
                    maxScore = currentScore;
                    winnerName = input;
                }
            }

           
            Console.WriteLine($"Winner is {winnerName} - {maxScore}!");
        }
    }
}
