using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        double grade = double.Parse(gradePercentage);
        if (grade >= 90)
        {
        Console.WriteLine("Your grade is an A.");
    }
    else if (grade >= 80)
{
        Console.WriteLine("Your grade is a B.");
}
    else if (grade >= 70)
{
        Console.WriteLine("Your grade is a C.");
}
    else
{
        Console.WriteLine("Your grade is a D or F.");
}
    if (grade >= 70)
    {
        Console.WriteLine("You have passed the course.");
    }
    else
    {
        Console.WriteLine("You have not passed the course.");
    }

    }

}