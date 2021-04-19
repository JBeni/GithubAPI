using Application.Handlers.Repositories.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class RepositoriesController : ApiControllerBase
    {
        [HttpGet("get-organization-repositories")]
        public async Task<IActionResult> GetOrganizationRepositories(GetOrganizationRepositoriesQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-repository")]
        public async Task<IActionResult> GetRepository(GetRepositoryQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-repository-contributors")]
        public async Task<IActionResult> GetRepositoryContributors(GetRepositoryContributorsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-branches")]
        public async Task<IActionResult> GetBranches(GetBranchesQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-branch")]
        public async Task<IActionResult> GetBranch(GetBranchQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
