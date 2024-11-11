namespace p04_Pochivka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double neededMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            int totalDays = 0;
            int spendDaysInARow = 0;

            
            while (money < neededMoney && spendDaysInARow < 5)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                totalDays++;

                if (action == "spend")
                {                    
                    money -= amount;
                    if (money < 0)
                    {
                        money = 0;
                    }
                    spendDaysInARow++;
                }
                else if (action == "save")
                {
                    money += amount;
                    spendDaysInARow = 0; 
                }
            }

           
            if (spendDaysInARow == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(totalDays);
            }
            else
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
        }
    }
    
}
