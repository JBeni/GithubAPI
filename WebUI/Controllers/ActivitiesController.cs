using Application.Handlers.Activities.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ActivitiesController : ApiControllerBase
    {
        [HttpGet("get-events")]
        public async Task<IActionResult> GetEvents(GetEventsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-network-public-events")]
        public async Task<IActionResult> GetNetworkPublicEvents(GetNetworkPublicEventsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-organization-public-events")]
        public async Task<IActionResult> GetOrganizationPublicEvents(GetOrganizationPublicEventsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-repository-events")]
        public async Task<IActionResult> GetRepositoryEvents(GetRepositoryEventsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-user-public-events")]
        public async Task<IActionResult> GetUserPublicEvents(GetUserPublicEventsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-user-received-public-events")]
        public async Task<IActionResult> GetUserReceivedPublicEvents(GetUserReceivedPublicEventsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
