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
            return Ok(result);
        }

        [HttpGet("get-public-gists")]
        public async Task<IActionResult> GetPublicGists(GetPublicGistsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-starred-gists")]
        public async Task<IActionResult> GetStarredGists(GetStarredGistsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-gist")]
        public async Task<IActionResult> GetGist(GetGistQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-gist-commits")]
        public async Task<IActionResult> GetGistCommits(GetGistCommitsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
