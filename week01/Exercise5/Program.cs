using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcomeMessage();
        string name = PromptUserForName();
        int favoriteNumber = userNumber();
        int squaredNumber = SquareNumber(favoriteNumber,  name);

    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserForName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int userNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        return number;
    }
    static int SquareNumber(int number , string name)
    {
        Console.WriteLine($"Brother {name}, the square of your number is: {number * number}");
        return number * number;
    }
}