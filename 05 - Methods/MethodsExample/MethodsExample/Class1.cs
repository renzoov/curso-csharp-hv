class Sample
{
    static void Main()
    {
        const string developerName = "harsha";

        Product product1, product2, product3;
        
        product1 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);
        product2 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);
        product3 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);

        product1.SetProductID(1001);
        product1.SetProductName("Mobile");
        product1.SetCost(20000);
        product1.SetQuantityInStock(1200);
        product2.SetProductID(1002);
        product2.SetProductName("Laptop");
        product2.SetCost(45000);
        product2.SetQuantityInStock(3400);
        product3.SetProductID(1003);
        product3.SetProductName("Speakers");
        product3.SetCost(36000);
        product3.SetQuantityInStock(800);

        double q = 9.2;
        product1.CalculateTax(percentage: out q);
        
        product2.CalculateTax(out double p);
        System.Console.WriteLine("p is " + p);
        
        product3.CalculateTax(10000, 3.4);
        
        System.Console.WriteLine(developerName);
        
        System.Console.WriteLine("Product 1:");
        System.Console.WriteLine("Product ID: " + product1.GetProductID());
        System.Console.WriteLine("Product Name: " +  product1.GetProductName());
        System.Console.WriteLine("Cost: " + product1.GetCost());
        System.Console.WriteLine("Quantity in Stock: " +  product1.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " +  product1.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " +  product1.GetTax());
        
        System.Console.WriteLine("Product 2:");
        System.Console.WriteLine("Product ID: " + product2.GetProductID());
        System.Console.WriteLine("Product Name: " +  product2.GetProductName());
        System.Console.WriteLine("Cost: " + product2.GetCost());
        System.Console.WriteLine("Quantity in Stock: " +  product2.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " +  product2.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " +  product2.GetTax());
        
        System.Console.WriteLine("Product 3:");
        System.Console.WriteLine("Product ID: " + product3.GetProductID());
        System.Console.WriteLine("Product Name: " +  product3.GetProductName());
        System.Console.WriteLine("Cost: " + product3.GetCost());
        System.Console.WriteLine("Quantity in Stock: " +  product3.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " +  product3.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " +  product3.GetTax());
        
        int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);
        System.Console.WriteLine("Total Quantity: " + totalQuantity);
        System.Console.WriteLine("Total no. of products: " + Product.GetTotalNoOfProducts());
        System.Console.WriteLine("Category of products: " + Product.CategoryName);

        System.Console.ReadKey();
    }
}