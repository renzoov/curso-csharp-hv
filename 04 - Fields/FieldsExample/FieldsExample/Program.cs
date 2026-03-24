class Sample
{
    static void Main()
    {
        //local sontant
        const string developerName = "Renzo";
        
        Product product1, product2, product3;
        
        product1 = new Product();
        Product.TotalNoProducts++; //1
        product2 = new Product();
        Product.TotalNoProducts++; //2
        product3 = new Product();
        Product.TotalNoProducts++; //3

        product1.productoID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;
        
        product2.productoID = 1002;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantityInStock = 3400;
        
        product3.productoID = 1003;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.quantityInStock = 800;
        
        System.Console.WriteLine(developerName);
        
        System.Console.WriteLine("Product 1:");
        System.Console.WriteLine("Product ID: " + product1.productoID);
        System.Console.WriteLine("Product Name: " + product1.productName);
        System.Console.WriteLine("Cost: " + product1.cost);
        System.Console.WriteLine("Quantity in Stock: " + product1.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product1.dateOfPurchase);
        
        System.Console.WriteLine("\nProduct 2:");
        System.Console.WriteLine("Product ID: " + product2.productoID);
        System.Console.WriteLine("Product Name: " + product2.productName);
        System.Console.WriteLine("Cost: " + product2.cost);
        System.Console.WriteLine("Quantity in Stock: " + product2.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product2.dateOfPurchase);
        
        System.Console.WriteLine("\nProduct 3:");
        System.Console.WriteLine("Product ID: " + product3.productoID);
        System.Console.WriteLine("Product Name: " + product3.productName);
        System.Console.WriteLine("Cost: " + product3.cost);
        System.Console.WriteLine("Quantity in Stock: " + product3.quantityInStock);
        System.Console.WriteLine("Date of Purchase: " + product3.dateOfPurchase);
        
        System.Console.WriteLine("Total no. of products: " + Product.TotalNoProducts);
        System.Console.WriteLine("Distributor of products: " + Product.Distributor);
        
        System.Console.ReadKey();
    }
}

public class InternationalProduct : Product
{
    public void Method1()
    {
        productID = 1; // not valid
        productName = "abc"; // accesible
        cost = 1000; // not valid
        quantityInStock = 1; // not valid
        category = "xyz"; // accesible
        size = 2; // accesible
    }
}

public class OtherClass2
{
    public void Method1()
    {
        Product product = new Product();
        product.productID = 1; // not valid
        product.productName = "abc"; // not valid
        product.cost = 2000; // not valid
        product.quantityInStock = 2; // not valid
        product.category = "xyz"; // not valid
        product.size = 2; // accesible
    }
}