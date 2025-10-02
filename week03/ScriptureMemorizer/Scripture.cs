class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        this._words = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;
        int attempts = 0;
        int maxAttempts = _words.Count * 2;

        List<Word> availableWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                availableWords.Add(word);
            }
        }

        if (availableWords.Count == 0)
        {
            return;
        }

        while (wordsHidden < numberToHide && availableWords.Count > 0 && attempts < maxAttempts)
        {
            int randomIndex = random.Next(availableWords.Count);
            Word word = availableWords[randomIndex];

            word.Hide();
            availableWords.RemoveAt(randomIndex);
            wordsHidden++;
            attempts++;
        }

    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";

        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
             }

        }
        return true;
    }
}