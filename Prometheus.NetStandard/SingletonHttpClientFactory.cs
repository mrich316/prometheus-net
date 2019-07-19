using System.Net.Http;

namespace Prometheus
{
    internal class SingletonHttpClientFactory : IHttpClientFactory
    {
        private static readonly HttpClient HttpClient = new HttpClient();

        public HttpClient CreateClient()
        {
            return HttpClient;
        }
    }
}
