class Program
{
    static void Main()
    {
        //int 
        int a = 1000;
        
        //string
        string b;
        
        //int --> string
        b = System.Convert.ToString(a);
        
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        System.Console.ReadKey();
    }
}