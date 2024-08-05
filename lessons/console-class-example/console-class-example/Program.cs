class Sample
{
    static void Main()
    {
        System.Console.WriteLine("This is a message displayed using WriteLine method, which displays line-by-line messages:");

        // WriteLine() print messages line-by-line
        System.Console.WriteLine("Welcome");
        System.Console.WriteLine("to");
        System.Console.WriteLine("C# Programming");

        System.Console.WriteLine("This is a message displayed using Write method, which displays side-by-side messages:");

        // Write() print messages side-by-side
        System.Console.Write("Welcome ");
        System.Console.Write("to ");
        System.Console.Write("C# Programming");

        System.Console.WriteLine();
        System.Console.WriteLine("Press any key to finish.");

        // ReadKey() wait for pressing some key on the keyboard
        System.Console.ReadKey();

        // Clear() clear the screen
        System.Console.Clear();

        System.Console.Write("Thank you!");
        System.Console.ReadKey();
    }
}
