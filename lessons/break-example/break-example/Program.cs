class Sample
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i > 5)
            {
                break;
            }

            System.Console.WriteLine(i);
        }

        System.Console.ReadKey();
    }
}
