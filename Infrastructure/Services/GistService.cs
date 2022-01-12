namespace Infrastructure.Services
{
    public class GistService : CommonService, IGistService
    {
        public async Task<GistResponse> GetGist(GetGistQuery query)
        {
            AuthenticateUserWithPersonalToken(_httpClient, query.PersonalGithubToken);
            var response = await _httpClient.GetAsync($"gists/{query.GistId}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<GistResponse>(content);
            return result;
        }

        public async Task<List<GistResponse>> GetGistCommits(GetGistCommitsQuery query)
        {
            AuthenticateUserWithPersonalToken(_httpClient, query.PersonalGithubToken);
            var response = await _httpClient.GetAsync($"gists/{query.GistId}/commits");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<GistResponse>>(content);
            return results;
        }

        public async Task<List<GistResponse>> GetGists(GetGistsQuery query)
        {
            AuthenticateUserWithPersonalToken(_httpClient, query.PersonalGithubToken);
            var response = await _httpClient.GetAsync($"gists");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<GistResponse>>(content);
            return results;
        }

        public async Task<List<GistResponse>> GetPublicGists(GetPublicGistsQuery query)
        {
            var response = await _httpClient.GetAsync($"gists/public");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<GistResponse>>(content);
            return results;
        }

        public async Task<List<GistResponse>> GetStarredGists(GetStarredGistsQuery query)
        {
            AuthenticateUserWithPersonalToken(_httpClient, query.PersonalGithubToken);
            var response = await _httpClient.GetAsync($"gists/starred");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<GistResponse>>(content);
            return results;
        }
    }
}
