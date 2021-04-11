using Application.Handlers.Activities.Queries;
using Application.Interfaces;
using Application.Responses;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ActivityService : CommonService, IActivityService
    {
        public async Task<List<EventResponse>> GetEvents(GetEventsQuery query)
        {
            var response = await _httpClient.GetAsync("events");
            var content = await response.Content.ReadAsStringAsync();
            var gists = JsonConvert.DeserializeObject<List<EventResponse>>(content);
            return gists;
        }
    }
}
