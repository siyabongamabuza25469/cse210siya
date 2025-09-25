using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    }

    // Class to represent the reference of the scripture
public class Reference
{
    private string _reference;

    public Reference(string reference)
    {
        _reference = reference;
    }

    public override string ToString()
    {
        return _reference;
    }
}

// Class to represent a word with functionality for hiding it
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    public void Hide()
    {
        _isHidden = true;
    }
}

// Class to represent the scripture
public class Scripture
{
    private Reference _reference;
    private List _words;

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = new List();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference);
        foreach (var word in _words)
        {
            Console.Write(word.GetText() + " ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWord(Random random)
    {
        var availableWords = _words.FindAll(w => w.GetText() == w.GetText()); // Only get visible words
        if (availableWords.Count == 0) return false;

        int index = random.Next(availableWords.Count);
        availableWords[index].Hide();
        return true;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of Scripture
        Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding.");
        
        // Random object for selecting words
        Random random = new Random();

        while (true)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit:");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide a random word
            if (!scripture.HideRandomWord(random))
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("All words are now hidden. Exiting...");
                break;
            }
        }
    }
}
}