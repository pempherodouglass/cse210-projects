using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("What is magic number? ");
        string magicNumberInput = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberInput);
         Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess = 0;
        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            string guessInput = Console.ReadLine();
            int userGuess = int.Parse(guessInput);
            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                break;
            }
        }
    }
}