namespace p15___PersonMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {       


            Person Peter = new Person();
            Peter.Name = "Peter Petrov";
            Peter.Age = 45;

            Peter.Accounts = new List<BankAccount>()
            {
                new BankAccount()
                {
                    Id = 1,
                    Balance = 1000.1
                },
                new BankAccount()
                {
                    Id = 2,
                    Balance = 2000.2
                },
                new BankAccount()
                {
                    Id=3,
                    Balance=3000.3
                }
            };

            Console.WriteLine($"Person: {Peter.Name}, Total Balance = {Peter.GetBalance()}");

        }
    }
}
