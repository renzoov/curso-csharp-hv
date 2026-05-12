using System;

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.PersonName = "John";
        person.Email = "john@gmail.com";
        person.AgeGroup = AgeGroupEnumeration.Adult;
        
        Console.WriteLine(person);
        Console.ReadKey();
    }
}