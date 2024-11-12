namespace p03_Private_Get_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FName = "Ivan";
            p.SName = "Ivanov";
            p.Age = 25;


            //1. Обект с конструктор, имайки =>  private set
            //2. Стойностите се задават само при създаването на обекта чрез конструктора.
            Person p1 = new Person("Petar","Petrov",25);
        }
    }
}
