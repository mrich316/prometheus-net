using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Prometheus
{
    class BasicAuthHttpClientFactory : IHttpClientFactory
    {
        private readonly HttpClient _client = new HttpClient();

        public BasicAuthHttpClientFactory(string user, string password)
        {
            var encoding = Encoding.GetEncoding("iso-8859-1");
            var headerValue = Convert.ToBase64String(encoding.GetBytes($"{user}:{password}"));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", headerValue);
        }

        public HttpClient CreateClient()
        {
            return _client;
        }
    }
}
