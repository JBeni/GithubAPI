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
    }
}
