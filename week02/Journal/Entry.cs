public class Entry
{
   public string _date;
   public string _prompText;
   public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date:{_date} - Prompt:{_prompText} ");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

}