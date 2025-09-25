using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
    }

    public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToShortDateString();
    }

    public override string ToString()
    {
        return $"{Date}: {Prompt}\n{Response}\n";
    }
}

public class Journal
{
    // Specify the type for the List
    private List entries = new List();
    private Random random = new Random();

    private readonly List prompts = new List
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void WriteNewEntry()
    {
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response);
        entries.Add(entry);
        Console.WriteLine("Entry saved!\n");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.\n");
            return;
        }

        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully!\n");
    }

    public void LoadJournal(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[1], parts[2]) { Date = parts[0] };
                        entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully!\n");
        }
        else
        {
            Console.WriteLine("File not found.\n");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveJournal(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadJournal(loadFile);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}
}

    