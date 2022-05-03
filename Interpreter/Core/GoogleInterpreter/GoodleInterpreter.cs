using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;

public class GoodleInterpreter : IInterpreter
{
    private const string URL = "https://translate.googleapis.com/translate_a/single?";

    private string _fromLanguage;
    private string _toLanguage;
    private HttpClient _httpClient;

    public GoodleInterpreter(string fromLanguage, string toLanguage)
    {
        _fromLanguage = fromLanguage;
        _toLanguage = toLanguage;

        _httpClient = new HttpClient();
    }

    public TranslateData Translate(string word)
    {
        try
        {
            var jsonText = _httpClient.GetStringAsync(GetTranslateUrl(word)).Result;
            var data = JsonConvert.DeserializeObject<GoogleTranslateData>(jsonText);

            var translateData = new TranslateData(data.sentences.FirstOrDefault().orig,
                data.sentences.FirstOrDefault().trans);

            return translateData;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException(ex.Message);
        }
    }

    public void ChangeFromLanguage(string language) =>
        _fromLanguage = language;

    public void ChangeToLanguage(string language) =>
        _toLanguage = language;

    private string GetTranslateUrl(string word) =>
        $"{URL}client=gtx&sl={_fromLanguage}&tl={_toLanguage}" +
        $"&hl=ru&dt=t&dt=bd&dj=1&source=icon&tk=467103.467103&q={Uri.EscapeUriString(word)}";
}
