namespace P14____Telephonia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SitesAndCalls sAc = new SitesAndCalls();
            //ICall call = sAc;


            ICall call = new SitesAndCalls();

            var calls=Console.ReadLine().Split(' ').ToArray();
            call.Call(calls);


            IBrowse browse = new SitesAndCalls();
            var browses = Console.ReadLine().Split(' ').ToArray();
            browse.Browse(browses);
        }
    }
}
