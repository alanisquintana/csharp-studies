public class Product
{
    public static List<Product> products = [];

    public string productId;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int totalNoProducts = 0;
    public const string categoryName = "Electronics";
    public readonly string dateOfPurchase;

    public Product(string productId, string productName, double cost, int quantityInStock)
    {
        this.productId = productId;
        this.productName = productName;
        this.cost = cost;
        this.quantityInStock = quantityInStock;
        this.dateOfPurchase = DateTime.Now.ToShortDateString();
        CalculateTax();

        products.Add(this);

        totalNoProducts++;
    }

    public static int TotalQuantity => products.Sum(p => p.quantityInStock);

    public static Product? MostExpensiveProduct => products.OrderByDescending(p => p.cost).FirstOrDefault();

    public override string ToString() => 
        $"\nID: {productId}\nName: {productName}" +
        $"\nCost: $ {cost:F2}" +
        $"\nQuantity in Stock: {quantityInStock}" +
        $"\nDate of Purchase: {this.dateOfPurchase}" +
        $"\nTax: $ {tax:F2}";

    public double CalculateTax()
    {
        tax = cost > 2000 ? cost * 12.5 / 100 : cost * 10 / 100;

        return tax;
    }
}


