using System.IO;
class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary(string filename)
    {
        this._scriptures = new List<Scripture>();
        this._random = new Random();
        LoadScripturesFromFile(filename);
    }

    private void LoadScripturesFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    string referencePart = parts[0].Trim();
                    string text = parts[1].Trim();

                    Reference reference = ParseReference(referencePart);
                    Scripture scripture = new Scripture(reference, text);
                    _scriptures.Add(scripture);
                }
            }
            Console.WriteLine($"Loaded {_scriptures.Count} scriptures from file.");

        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File '{filename}' not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures: {ex.Message}");
        }

    }
    private Reference ParseReference(string referenceText)
    {
        string[] parts = referenceText.Split(' ');
        string chapterVerse = parts[parts.Length - 1];
        string book = string.Join(" ", parts, 0, parts.Length - 1);
        string[] cvParts = chapterVerse.Split(":");
        int chapter = int.Parse(cvParts[0]);
        if (cvParts[1].Contains('-'))
        {
            string[] verseParts = cvParts[1].Split('-');
            int startVerse = int.Parse(verseParts[0]);
            int endVerse = int.Parse(verseParts[1]);
            return new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            int verse = int.Parse(cvParts[1]);
            return new Reference(book, chapter, verse);
        }

    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            throw new InvalidOperationException("No scriptures available in tyje libary.");
        }
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }

    public int GetScriptureCount()
    {
        return _scriptures.Count;
    }
}