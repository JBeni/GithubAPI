namespace WebUI.Controllers
{
    public class RepositoriesController : ApiControllerBase
    {
        [HttpGet("get-organization-repositories")]
        public async Task<IActionResult> GetOrganizationRepositories([FromQuery] GetOrganizationRepositoriesQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-repository")]
        public async Task<IActionResult> GetRepository([FromQuery] GetRepositoryQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-repository-contributors")]
        public async Task<IActionResult> GetRepositoryContributors([FromQuery] GetRepositoryContributorsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-branches")]
        public async Task<IActionResult> GetBranches([FromQuery] GetBranchesQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-branch")]
        public async Task<IActionResult> GetBranch([FromQuery] GetBranchQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
