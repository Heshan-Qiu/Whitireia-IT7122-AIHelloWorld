using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace AIHelloWorldForms
{
    #region
    /// <summary>
    /// The C# classes that represents the JSON returned by the Text Analytics API.
    /// </summary>
    class RequestDocument
    {
        public string Id { get; set; }
        public string Text { get; set; }
    }

    class LanguageDetectionPackage
    {
        public RequestDocument[] Documents { get; set; }
    }

    class DetectedLanguage
    {
        public string Name { get; set; }
        public string Iso6391Name { get; set; }
        public float Score { get; set; }
    }

    class ResultDocument
    {
        public string Id { get; set; }
        public DetectedLanguage[] DetectedLanguages { get; set; }
    }

    class ResultPackage
    {
        public ResultDocument[] Documents { get; set; }
        public object[] Errors { get; set; }
    }
    #endregion

    class LanguageDector : CognitiveRequest
    {
        private const string END_POINT = "https://heshan-text-analytics.cognitiveservices.azure.com/text/analytics/v2.1/languages";
        private const string API_KEY = "39d2483356944f7ea08450d793689fcc";

        public LanguageDector() : base(END_POINT, API_KEY) {}

        public async Task<DetectedLanguage> DetectLanguage(string text)
        {
            RequestDocument document = new RequestDocument()
            {
                Id = "1",
                Text = text
            };
            LanguageDetectionPackage body = new LanguageDetectionPackage()
            {
                Documents = new RequestDocument[] { document }
            };
            var requestBody = JsonConvert.SerializeObject(body);
            Console.WriteLine("测试：" + requestBody);

            string response = await Send(requestBody);
            Console.WriteLine("测试：" + response);

            ResultPackage result = JsonConvert.DeserializeObject<ResultPackage>(response);
            return result.Documents[0].DetectedLanguages[0];
        }
    }
}
