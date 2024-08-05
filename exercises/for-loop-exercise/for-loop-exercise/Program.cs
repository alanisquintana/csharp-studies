using System;

/*
 
    Write a C# program to print the following output:

    1 2 3 4 7 8 9 10
    1 2 3 4 7 8 9 10
    1 2 3 4 7 8 9 10
    10 9 8 7 6 5 4 3 2 1
    10 9 8 7 6 5 4 3 2 1
    10 9 8 7 6 5 4 3
    10 9 8 7 6 5 4 3 2 1
    1 2 3 4 5 6 7 9 10

*/

class Sample
{
    static void Main()
    {
        for (int i = 1; i <= 8; i++)
        {
            if (i >= 4 && i <= 7)
            {
                for (int k = 10; k >= 1; k--)
                {
                    if (i == 6 && k < 3)
                    {
                        break;
                    }

                    Console.Write(k + " ");
                }
            }

            else
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i <= 3 && j == 5 || j == 6)
                    {
                        continue;
                    }
                    
                    Console.Write(j + " ");
                }
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
