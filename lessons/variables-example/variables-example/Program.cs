class Sample
{
    static void Main()
    {
        // Declare the varible
        string userName = "George";
        int userAge = 27;

        // Printing values using interpolation
        System.Console.Write($"Hello, { userName}. Your age is { userAge }.");

        System.Console.ReadKey();
    }
}
