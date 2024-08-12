class Sample
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }

            System.Console.WriteLine(i);
        }

        System.Console.ReadKey();
    }
}
