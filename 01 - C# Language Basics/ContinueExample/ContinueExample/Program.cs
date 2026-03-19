namespace ContinueExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 6)
                {
                    continue;
                }
                System.Console.WriteLine(i);
            }
            
            System.Console.ReadKey();
        }
    }
}