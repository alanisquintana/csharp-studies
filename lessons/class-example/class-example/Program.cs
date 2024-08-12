class Sample
{
    static void Main()
    {
        Customer c1, c2;
        c1 = new Customer("001", "Jane");
        c2 = new Customer("002", "John");

        Console.WriteLine($"Costumer Id: {c1.customerId}\nCostumer Name: {c1.customerName}");
        Console.WriteLine($"Costumer Id: {c2.customerId}\nCostumer Name: {c2.customerName}");

        Console.ReadKey();
    }
}
