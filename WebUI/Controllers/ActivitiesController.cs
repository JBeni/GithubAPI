using Application.Handlers.Activities.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ActivitiesController : ApiControllerBase
    {
        [HttpGet("get-events")]
        public async Task<IActionResult> GetEvents([FromQuery] GetEventsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        public class NetworkEventModel
        {
            public string Owner { get; set; }
            public string Repo { get; set; }
        }

        [HttpGet("get-network-events")]
        public async Task<IActionResult> GetNetworkEvents([FromQuery] NetworkEventModel model)
        {
            //var response = await _httpClient.GetAsync($"networks/{model.Owner}/{model.Repo}/events");
            //var content = await response.Content.ReadAsStringAsync();
            //var events = JsonConvert.DeserializeObject<List<Event>>(content);
            return Ok();
        }
    }
}
