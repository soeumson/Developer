using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.ApiConlletion
{
    public abstract class HttpClientWithFactory
    {
        private readonly IHttpClientFactory _factory;
        public Uri BaseAddress { get; set; }
        public string BasePath { get; set; }
        public HttpClientWithFactory(IHttpClientFactory factory)
        => _factory = factory;
        private HttpClient GetHttpClient()
        {
            return _factory.CreateClient();
        }
        public virtual async Task<T> SendRequest<T>(HttpRequestMessage request)
        where T : class
        {
            var client = GetHttpClient();
            var response = await client.SendAsync(request);
            T result = null;
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<T>(GetFormatters());
            }
            else
            {
                Log.Error("Something went wrong api call " + await response.Content.ReadAsAsync<string>());
            }
            return result;
        }
        protected virtual IEnumerable<MediaTypeFormatter> GetFormatters()
        {
            // Make JSON the default
            return new List<MediaTypeFormatter> { new JsonMediaTypeFormatter() };
        }
    }
}
