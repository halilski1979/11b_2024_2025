namespace P14____Telephonia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sAc = new SitesAndCalls();
            ICall call = sAc;
            call.Call(Console.ReadLine().Split(' '));
            IBrowse browse = sAc;
            browse.Browse(Console.ReadLine().Split(' '));
        }
    }
}
