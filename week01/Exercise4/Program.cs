class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int userInput = -1;
        while (userInput != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            userInput = int.Parse(input);
            if (userInput != 0)
            {
                numbers.Add(userInput);
            } 
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum of the numbers is: {max}");
    }
}