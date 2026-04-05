class Program
{
    static void Main()
    {
        //create an object of Car class
        Car c = new Car();
        
        //call get accesor of indexer
        System.Console.WriteLine(c[0]);
        System.Console.WriteLine(c["first"]);
        
        //call set accesor of index
        c[0] = "Nissan";
        System.Console.WriteLine(c[0]);

        System.Console.ReadKey();
    }
}