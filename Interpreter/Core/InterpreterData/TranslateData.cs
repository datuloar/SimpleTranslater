public class TranslateData
{
    public TranslateData(string sourceWord, string translateWord)
    {
        SourceWord = sourceWord;
        TranslateWord = translateWord;
    }

    public string SourceWord { get; private set; }
    public string TranslateWord { get; private set; }
}