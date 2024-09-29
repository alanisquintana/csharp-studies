namespace ClassLibrary
{
    public class Product
    {
        public static List<Product> products = [];

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double Cost { get; set; }
        public double Tax { get; private set; }
        public int QuantityInStock { get; set; }
        public static int TotalNoProducts { get; set; }
        public const string categoryName = "Electronics";
        public readonly string dateOfPurchase;

        public Product(string productId, string productName, double cost, int quantityInStock)
        {
            ProductId = productId;
            ProductName = productName;
            Cost = cost;
            QuantityInStock = quantityInStock;
            dateOfPurchase = DateTime.Now.ToShortDateString();
            CalculateTax();

            products.Add(this);

            TotalNoProducts++;
        }

        public static int TotalQuantity => products.Sum(p => p.QuantityInStock);

        public static Product? MostExpensiveProduct => products.OrderByDescending(p => p.Cost).FirstOrDefault();

        public override string ToString() =>
            $"\nID: {ProductId}\nName: {ProductName}" +
            $"\nCost: $ {Cost:F2}" +
            $"\nQuantity in Stock: {QuantityInStock}" +
            $"\nDate of Purchase: {dateOfPurchase}" +
            $"\nTax: $ {Tax:F2}";

        public double CalculateTax()
        {
            Tax = Cost > 2000 ? Cost * 12.5 / 100 : Cost * 10 / 100;

            return Tax;
        }
    }

}
