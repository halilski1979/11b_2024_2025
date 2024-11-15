namespace p10_AutoProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person human = new Person();
           human.FName = "Petar";
            human.SName = "Pterov";
            human.Age = 30;
            human.Salary = 2230;

            human.GetAll();
            human.IncreaseAge();
            human.GetAll();
            
        }
    }
}
