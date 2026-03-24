public class Product
{
    private int productoID;
    protected string productName;
    private protected double cost;
    internal int quantityInStock;
    protected internal string category;
    public int size;
    public static int TotalNoProducts;
    public const string Distributor = "Sony";
    public readonly string dateOfPurchase;

    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }
}

public class DomesticProduct : Product
{
    public void Method1()
    {
        productID = 1; // not valid
        productName = "abc"; // accesible
        cost = 1000; // accesible
        quantityInStock = 1; // accesible
        category = "xyz"; // accesible
        size = 2; // accesible
    }
}

public class OtherClass
{
    public void Method1()
    {
        Product product = new Product();
        product.productID = 1; // not valid
        product.productName = "abc"; // not valid
        product.cost = 2000; // not valid
        product.quantityInStock = 2; // accesible
        product.category = "xyz"; // accesible
        product.size = 2; // accesible
    }
}