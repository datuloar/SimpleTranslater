public interface IInterpreter
{
    TranslateData Translate(string word);
    void ChangeFromLanguage(string language);
    void ChangeToLanguage(string language);
}
