public class Product
{
    private int productID;
    private string productName;
    private double cost;
    private double tax;
    private int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    private readonly string dateOfPurchase;

    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    public void SetProductID(int productID)
    {
        this.productID = productID;
    }

    public int GetProductID()
    {
        return productID;
    }
    
    public void SetProductName(string value)
    {
        productName = value;
    }

    public string GetProductName()
    {
        return productName;
    }
    
    public void SetCost(double value)
    {
        cost = value;
    }

    public double GetCost()
    {
        return cost;
    }
    
    public void SetTax(double value)
    {
        tax = value;
    }

    public double GetTax()
    {
        return tax;
    }
    
    public void SetQuantityInStock(int value)
    {
        quantityInStock = value;
    }

    public int GetQuantityInStock()
    {
        return quantityInStock;
    }
    
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }

    public static void SetTotalNoOfProducts(int value)
    {
        TotalNoProducts = value;
    }
    
    public static int GetTotalNoOfProducts()
    {
        return TotalNoProducts;
    }

    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        int total;
        total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        return total;
    }

    public void CalculateTax(out double percentage)
    {
        percentage = 10.45;
        
        double t;

        if (cost <= 20000)
        {
            t = cost * 10 / 1000;
        }
        else
        {
            t = cost * percentage / 100;
        }

        tax = t;
    }
    
    public void CalculateTax(double cost, double percentage)
    {
        double t;

        if (cost <= 50000)
        {
            t = cost * 5 / 1000;
        }
        else
        {
            t = cost * percentage / 100;
        }

        tax = t;
    }
}