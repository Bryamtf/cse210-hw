using System.Formats.Asn1;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._prompText}|{entry._entryText}");
                }
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to save journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        try
        {
            _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to load journal: {ex.Message}");
        }
    }
}