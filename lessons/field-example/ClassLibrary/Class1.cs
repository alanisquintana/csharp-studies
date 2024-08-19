using System.Collections.Generic;

public class Product
{
    public static List<Product> products = new List<Product>();

    public string productId;
    public string productName;
    public double cost;
    public int quantityInStock;

    public Product (string productId, string productName, double cost, int quantityInStock)
    {
        this.productId = productId;
        this.productName = productName;
        this.cost = cost;
        this.quantityInStock = quantityInStock;

        products.Add(this);
    }

    public static int TotalQuantity => products.Sum(p => p.quantityInStock);

    public static Product MostExpensiveProduct => products.FirstOrDefault(p => p.cost == products.Max(p => p.cost));

    public override string ToString()
    {
        return $"\nID: {productId}\nName: {productName}\nCost: {cost}\nQuantity in Stock: {quantityInStock}";
    }
}
