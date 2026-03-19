namespace IfExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //declare variable to store marks of the student
            int marks = 45;
            
            //show congratulations if the student has passed
            if (marks >= 35)
            {
                System.Console.WriteLine("Congratulations");
            }
            
            System.Console.ReadKey();
        }
    }
}