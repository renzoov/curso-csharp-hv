namespace WhileExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;

            while (i <= 10)
            {
                System.Console.Write(i + " ");
                i++;
            }
            System.Console.WriteLine();

            i = 0;
            while (i < 10)
            {
                System.Console.Write(i + " ");
                i++;
            }
            
            i = 9;
            while (i >= 0)
            {
                System.Console.Write(i + " ");
                i--;
            }
            
            System.Console.ReadKey();
        }
    }
}