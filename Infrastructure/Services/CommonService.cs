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
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        }

        public void AuthenticateUserWithPersonalToken(HttpClient httpClient, string token)
        {
            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", token);
            }
        }
    }
}
