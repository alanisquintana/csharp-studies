class Sample
{
    static void Main()
    {
        // Increment / Decrement operators
        decimal a = 10M;

        // The increment/decrement operator after the variable starts a loop

        System.Console.WriteLine(++a); // Output: 11
        System.Console.WriteLine(a++); // Output: 11
        System.Console.WriteLine(a); // Output: 12
        System.Console.WriteLine(--a); // output: 11
        System.Console.WriteLine(a--); //Output: 11
        System.Console.WriteLine(a); //Output: 10


        // Ternary operator
        string userName = "George";
        int userAge = 27;

        // (condition)? if true : if false
        string title = (userAge < 13) ? "a child" : (userAge >= 13 && userAge <= 19) ? "a teenager" : "an adult";
        System.Console.WriteLine($"User { userName } with { userAge } years old is { title }.");

        System.Console.ReadKey();
    }
}
