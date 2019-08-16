using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AIHelloWorldForms
{
    class CognitiveRequest
    {
        public string EndPoint { get; set; }
        public string SubscriptionKey { get; set; }

        public CognitiveRequest(string endPoint, string subscriptionKey)
        {
            EndPoint = endPoint;
            SubscriptionKey = subscriptionKey;
        }

        public async Task<string> Send(string requestBody)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage();

            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(EndPoint);
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            request.Headers.Add("Ocp-Apim-Subscription-Key", SubscriptionKey);

            HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
            string result = await response.Content.ReadAsStringAsync();

            return result;
        }
    }
}
