class Comment
{
    private string _commenterName;
    private string _commenterText;


    public Comment() { }
    public Comment(string namePerson, string comment)
    {
        this._commenterName = namePerson;
        this._commenterText = comment;
    }
    private string GetCommenterName()
    {
        return this._commenterName;
    }

    private string GetCommenterText()
    {
        return this._commenterText;
    }

    public void Display()
    {
        Console.WriteLine($"{GetCommenterName()}: {GetCommenterText()}");
    }   


}