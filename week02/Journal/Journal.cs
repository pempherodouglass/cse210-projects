using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProgram
{
    public class Journal
    {

        private List<Entry> _entries = new List<Entry>();
        private List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned or realized today?",
            "Describe a moment of peace or quiet you experienced today."
        };

        public string GetRandomPrompt()
        {
            Random ran = new Random();
            int choice = ran.Next(0, _prompts.Count);
            return _prompts[choice];
        }

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("The journal is currently empty.");
                return;
            }

            Console.WriteLine("\n--- Journal Entries ---");
            foreach (Entry item in _entries)
            {
                item.Display();
            }
            Console.WriteLine("-----------------------");
        }

        public void SaveToFile(string file)
        {
        
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry item in _entries)
                {
                    writer.WriteLine(item.Date + "|" + item.PromptText + "|" + item.EntryText);
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }

        public void LoadFromFile(string file)
        {
            if (File.Exists(file))
            {
                _entries.Clear();
                string[] lines = File.ReadAllLines(file);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry loadedEntry = new Entry(parts[0], parts[1], parts[2]);
                        _entries.Add(loadedEntry);
                    }
                }
                Console.WriteLine("Journal loaded successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
