namespace WebUI.Controllers
{
    public class GitDatabasesController : ApiControllerBase
    {
        [HttpGet("get-blob")]
        public async Task<IActionResult> GetBlob([FromQuery] GetBlobQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-commit")]
        public async Task<IActionResult> GetCommit([FromQuery] GetCommitQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-reference")]
        public async Task<IActionResult> GetReference([FromQuery] GetReferenceQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-tag")]
        public async Task<IActionResult> GetTag([FromQuery] GetTagQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
