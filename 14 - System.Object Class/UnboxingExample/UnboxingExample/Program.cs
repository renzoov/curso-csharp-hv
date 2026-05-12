using System;

class Program
{
    static void Main()
    {
        object obj = 10;

        int x = (int)obj;
        
        Console.WriteLine(x);
        Console.WriteLine(obj);
        Console.ReadKey();
    }
}