namespace ForExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
            
            for (int i = 0; i < 10; i++)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
            
            for (int i = 9; i >= 0; i--)
            {
                System.Console.Write(i + " ");
            }
            
            System.Console.ReadKey();
        }
    }
}