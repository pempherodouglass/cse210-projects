using System;

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal activeJournal = new Journal();
            bool run = true;

            Console.WriteLine("Welcome to the Personal Journal Program!");

            while (run)
            {
                Console.WriteLine("\nPlease select one of the following choices:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Load the journal from a file");
                Console.WriteLine("4. Save the journal to a file");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");
                
                string input = Console.ReadLine();

                if (input == "1")
                {
                    string prompt = activeJournal.GetRandomPrompt();
                    Console.WriteLine("\nPrompt: " + prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    DateTime current = DateTime.Now;
                    string dateStr = current.ToShortDateString();

                    Entry newEntry = new Entry(dateStr, prompt, response);
                    activeJournal.AddEntry(newEntry);

                    string[] words = response.Split(' ');
                    if (words.Length > 15)
                    {
                        Console.WriteLine("Wonderful details! Exceptional job expressing your day.");
                    }
                    else
                    {
                        Console.WriteLine("Entry recorded. Keep up the daily habit!");
                    }
                }
                else if (input == "2")
                {
                    activeJournal.DisplayAll();
                }
                else if (input == "3")
                {
                    Console.Write("What is the filename? ");
                    string file = Console.ReadLine();
                    activeJournal.LoadFromFile(file);
                }
                else if (input == "4")
                {
                    Console.Write("What is the filename? ");
                    string file = Console.ReadLine();
                    activeJournal.SaveToFile(file);
                }
                else if (input == "5")
                {
                    Console.WriteLine("Thank you for archiving your life today. Goodbye!");
                    run = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }
    }
}
