public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // By default, the word is not hidden
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false; // Set the word to be visible

    }
    public bool IsHidden()
    {
        return _isHidden; // Return the hidden status of the word
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);

        }
        else
        {
            return _text; // Return the actual word if it is not hidden
        }
    }
}