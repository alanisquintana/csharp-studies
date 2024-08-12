class Sample
{
    static void Main()
    {
        // Declare the varible
        string userName = "George";
        int age = 27;

        // Printing values using interpolation
        System.Console.Write($"Hello, { userName}. Your age is { age }.");

        System.Console.ReadKey();
    }
}
