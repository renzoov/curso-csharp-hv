namespace DoWhileExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;

            do
            {
                System.Console.Write(i + " ");
                i++;
            } while (i <= 10);
            System.Console.WriteLine();

            i = 0;
            do
            {
                System.Console.Write(i + " ");
                i++;
            } while (i < 10);
            System.Console.WriteLine();
            
            i = 9;
            do
            {
                System.Console.Write(i + " ");
                i--;
            } while (i >= 0);
            
            System.Console.ReadKey();
        }
    }
}