using System;

class Program
{
    static void Main()
    {
        Marvel m = new Marvel("Thanos");
        
        Console.WriteLine((m.CharacterName));
        m.PrintCharacterName();

        Console.ReadKey();
    }
}