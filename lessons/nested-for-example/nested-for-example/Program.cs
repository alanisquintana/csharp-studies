class Sample
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                System.Console.Write(j);
            }

            System.Console.WriteLine();
        }

        System.Console.ReadKey();
    }
}
