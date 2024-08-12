class Sample
{
    static void Main()
    {
        int averageGrade = 70;

        int studentGrade = 59;

        // if-else
        if (studentGrade < averageGrade)
        {
            System.Console.Write("You failed. ");
        }
        else 
        {
            System.Console.Write("You passed! ");
        }

        char gradeLetter;

        // else-if
        if (studentGrade >= 85) 
        {
            gradeLetter = 'A';
        } 
        else if (studentGrade >= 60 && studentGrade < 85)
        {
            gradeLetter = 'B';    
        }
        else
        {
            gradeLetter = 'C';
        }

        System.Console.Write($"Your grade letter is { gradeLetter }.");



        System.Console.ReadKey();
    }
}
