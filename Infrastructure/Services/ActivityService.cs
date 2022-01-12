namespace Infrastructure.Services
{
    public class ActivityService : CommonService, IActivityService
    {
        public async Task<List<EventResponse>> GetEvents(GetEventsQuery query)
        {
            var response = await _httpClient.GetAsync("events");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<EventResponse>>(content);
            return results;
        }

        public async Task<List<EventResponse>> GetNetworkPublicEvents(GetNetworkPublicEventsQuery query)
        {
            var response = await _httpClient.GetAsync($"networks/{query.Owner}/{query.Repo}/events");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<EventResponse>>(content);
            return results;
        }

        public async Task<List<EventResponse>> GetOrganizationPublicEvents(GetOrganizationPublicEventsQuery query)
        {
            var response = await _httpClient.GetAsync($"orgs/{query.Organization}/events");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<EventResponse>>(content);
            return results;
        }

        public async Task<List<EventResponse>> GetRepositoryEvents(GetRepositoryEventsQuery query)
        {
            var response = await _httpClient.GetAsync($"repos/{query.Owner}/{query.Repo}/events");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<EventResponse>>(content);
            return results;
        }

        public async Task<List<EventResponse>> GetUserPublicEvents(GetUserPublicEventsQuery query)
        {
            var response = await _httpClient.GetAsync($"users/{query.Username}/events/public");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<EventResponse>>(content);
            return results;
        }

        public async Task<List<EventResponse>> GetUserReceivedPublicEvents(GetUserReceivedPublicEventsQuery query)
        {
            var response = await _httpClient.GetAsync($"users/{query.Username}/received_events/public");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<EventResponse>>(content);
            return results;
        }
    }
}
