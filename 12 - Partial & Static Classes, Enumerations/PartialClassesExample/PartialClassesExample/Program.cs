using Warehouse;
using static System.Console;

class Program
{
    static void Main()
    {
        Product product = new Product();

        product.ProductID = 101;
        product.Cost = 1000;

        product.CallGetTax();

        ReadKey();
    }
}