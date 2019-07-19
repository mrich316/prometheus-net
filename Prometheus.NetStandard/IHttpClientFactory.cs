using System.Net.Http;

namespace Prometheus
{
    public interface IHttpClientFactory
    {
        HttpClient CreateClient();
    }
}
