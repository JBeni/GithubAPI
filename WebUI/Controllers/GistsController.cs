namespace WebUI.Controllers
{
    public class GistsController : ApiControllerBase
    {
        [HttpGet("get-gists")]
        public async Task<IActionResult> GetGists([FromQuery] GetGistsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-public-gists")]
        public async Task<IActionResult> GetPublicGists([FromQuery] GetPublicGistsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-starred-gists")]
        public async Task<IActionResult> GetStarredGists([FromQuery] GetStarredGistsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-gist")]
        public async Task<IActionResult> GetGist([FromQuery] GetGistQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-gist-commits")]
        public async Task<IActionResult> GetGistCommits([FromQuery] GetGistCommitsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
