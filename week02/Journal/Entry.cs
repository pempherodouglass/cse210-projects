using System;

namespace JournalProgram
{
    public class Entry
    {
        
        public string Date;
        public string PromptText;
        public string EntryText;

        public Entry(string date, string promptText, string entryText)
        {
            Date = date;
            PromptText = promptText;
            EntryText = entryText;
        }

        public void Display()
        {
            Console.WriteLine("Date: " + Date + " - Prompt: " + PromptText);
            Console.WriteLine(EntryText);
            Console.WriteLine();
        }
    }
}
