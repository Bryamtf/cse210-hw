class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video() { }

    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
        this._comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        this._comments.Add(comment);
    }
    public int GetNumberComments()
    {
        return this._comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"\nVideo: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
    
}