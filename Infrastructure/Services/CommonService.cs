using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Infrastructure.Services
{
    public class CommonService
    {
        protected HttpClient _httpClient;

        public CommonService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.github.com/")
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("GithubAPI", "v1"));
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
