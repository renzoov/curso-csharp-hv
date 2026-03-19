namespace IfElseExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int marks = 70;

            if (marks >= 35)
            {
                System.Console.WriteLine("Congratulations");
            }
            else
            {
                System.Console.WriteLine("Better luck next time");
            }
            
            System.Console.ReadKey();
        }
    }
}