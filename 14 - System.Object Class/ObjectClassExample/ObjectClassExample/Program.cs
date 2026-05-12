using System;

class Program
{
    static void Main()
    {
        System.Object obj = new Person() { PersonName = "Scott", Email = "scott@gmail.com" };
        
        Console.WriteLine(obj.Equals(new Person() { PersonName = "Scott", Email = "scott@gmail.com" }));
        Console.WriteLine(obj.GetHashCode());
        Console.WriteLine(obj.ToString());
        Console.WriteLine(obj.GetType().ToString());

        Console.ReadKey();
    }
}