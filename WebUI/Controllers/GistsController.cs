using Application.Handlers.Gists.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class GistsController : ApiControllerBase
    {
        [HttpGet("get-gists")]
        public async Task<IActionResult> GetGists(GetGistsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok();
        }
    }
}
