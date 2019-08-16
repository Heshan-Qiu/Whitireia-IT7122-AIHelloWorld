using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace AIHelloWorldForms
{
    #region
    /// <summary>
    /// The C# classes that represents the JSON returned by the Translator Text API.
    /// </summary>
    class Alignment
    {
        public string Proj { get; set; }
    }

    class SentenceLength
    {
        public int[] SrcSentLen { get; set; }
        public int[] TransSentLen { get; set; }
    }

    class DetectedLanguage2
    {
        public string Language { get; set; }
        public float Score { get; set; }
    }

    class TextResult
    {
        public string Text { get; set; }
        public string Script { get; set; }
    }

    class Translation
    {
        public string Text { get; set; }
        public TextResult Transliteration { get; set; }
        public string To { get; set; }
        public Alignment Alignment { get; set; }
        public SentenceLength SentLen { get; set; }
    }

    class TranslationResult
    {
        public DetectedLanguage2 DetectedLanguage { get; set; }
        public TextResult SourceText { get; set; }
        public Translation[] Translations { get; set; }
    }
    #endregion

    class LanguageTranslator : CognitiveRequest
    {
        private const string HOST = "https://api.cognitive.microsofttranslator.com";
        private const string ROUTE = "/translate?api-version=3.0";
        private const string API_KEY = "713275fe21a54b999d31bd242c40bcc9";

        public LanguageTranslator() : base(HOST + ROUTE, API_KEY) { }

        public async Task<string> Translate(string to, string text)
        {
            EndPoint = HOST + ROUTE + "&to=" + to;

            object[] body = new object[] { new { Text = text } };
            var requestBody = JsonConvert.SerializeObject(body);
            Console.WriteLine("测试：" + requestBody);

            string response = await Send(requestBody);
            Console.WriteLine("测试：" + response);

            TranslationResult[] results = JsonConvert.DeserializeObject<TranslationResult[]>(response);
            return results[0].Translations[0].Text;
        }

        public async Task<string> GetTranslatedLanguageName(string text)
        {
            EndPoint = HOST + ROUTE + "&to=en";

            object[] body = new object[] { new { Text = text } };
            var requestBody = JsonConvert.SerializeObject(body);
            Console.WriteLine("测试：" + requestBody);

            string response = await Send(requestBody);
            Console.WriteLine("测试：" + response);

            TranslationResult[] results = JsonConvert.DeserializeObject<TranslationResult[]>(response);
            return results[0].DetectedLanguage.Language;
        }
    }
}
