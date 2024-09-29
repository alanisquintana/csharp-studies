using ClassLibrary;

class Sample
{
    static void Main()
    {
        const string developerName = "Alanis Quintana";

        Product product1 = new("001", "Mobile", 1800.00, 120);
        Product product2 = new("002", "Laptop", 2600.90, 80);
        Product product3 = new("003", "Speakers", 80.25, 60);

        if (Product.products.Count == 0)
        {
            Console.WriteLine("No products available.");

            Console.ReadKey();

            return;
        }

        Console.WriteLine($"\nCategory of Products: {Product.categoryName}");

        foreach (var product in Product.products)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("\n-----------------------------------");

        Console.WriteLine($"\nTotal Quantity in Stock: {Product.TotalQuantity}");

        Console.WriteLine($"\nTotal Number of Products: {Product.TotalNoProducts}");

        Console.WriteLine($"\nMost Expensive Product:\n {Product.MostExpensiveProduct}");

        Console.WriteLine("\n-----------------------------------");

        Console.WriteLine($"Developer: {developerName}");

        Console.ReadKey();
    }
}
