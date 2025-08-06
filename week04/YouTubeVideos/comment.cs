public class Comment
{
    private string _authorName;
    private string _text;

    public Comment(string authorName, string text)
    {
        _authorName = authorName;
        _text = text;
    }
    public string GetDisplayText()
    {
        return $"{_authorName}: {_text}";
    }
}