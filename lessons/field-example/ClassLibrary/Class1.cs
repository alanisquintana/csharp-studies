using System.Collections.Generic;
using System.Linq;

public class Product
{
    public static List<Product> products = new List<Product>();

    public string ProductId;
    public string ProductName;
    public double Cost;
    public int QuantityInStock;
    public static int TotalNoProducts = 0;
    public const string CategoryName = "Electronics";
    public readonly string DateOfPurchase;

    public Product (string ProductId, string ProductName, double Cost, int QuantityInStock)
    {
        this.ProductId = ProductId;
        this.ProductName = ProductName;
        this.Cost = Cost;
        this.QuantityInStock = QuantityInStock;
        this.DateOfPurchase = System.DateTime.Now.ToShortDateString();

        products.Add(this);

        TotalNoProducts++;
    }

    public static int TotalQuantity => products.Sum(p => p.QuantityInStock);

    public static Product MostExpensiveProduct => products.FirstOrDefault(p => p.Cost == products.Max(p => p.Cost));

    public override string ToString()
    {
        return $"\nID: {ProductId}\nName: {ProductName}\nCost: $ {Cost}\nQuantity in Stock: {QuantityInStock}\nDate of Purchase: {this.DateOfPurchase}";
    }
}
