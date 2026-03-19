namespace GotoExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            System.Console.WriteLine("USA");
            System.Console.WriteLine("UK");
            System.Console.WriteLine("India");
            mylabel:
            System.Console.WriteLine("Germany");
            System.Console.WriteLine("France");
            System.Console.WriteLine("Italy");
            i++;
            if (i < 3)
            {
                goto mylabel;
            }
            System.Console.WriteLine("Nepal");
            System.Console.WriteLine("Colombia");
            
            System.Console.ReadKey();
        }
    }
}