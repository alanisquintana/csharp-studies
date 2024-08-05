class Sample
{
    static void Main()
    {
        char gradeLetter = 'A';

        string gradeDescription;

        switch (gradeLetter)
        {
            case 'A': gradeDescription = "Excellent!"; break;
            case 'B': gradeDescription = "Good!"; break;
            case 'C': gradeDescription = "Average."; break;

            default: gradeDescription = "None"; break;
        }

        System.Console.WriteLine(gradeDescription);
        System.Console.ReadKey();

    }
}
