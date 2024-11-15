namespace p10_BancAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccound accound = new BankAccound();
            accound.Id = 1;
            accound.Balance = 2000;
           
            //Console.WriteLine($"Account: {accound.Id},balance:{accound.Balance}lv.");
             BankAccound acc = new BankAccound();
            acc.Id = 2;
            acc.Balance = 3000;
            //Console.WriteLine($"Account: {acc.Id},balance:{acc.Balance}lv.");

            accound.GetAccount();
            acc.GetAccount();
            accound.Deposit(100);
            accound.GetAccount();
            acc.Teglene(1000);
            acc.GetAccount();
        }
    }
}
