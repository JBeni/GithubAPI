using Application.Handlers.Actions.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ActionsController : ApiControllerBase
    {
        [HttpGet("get-artifact")]
        public async Task<IActionResult> GetArtifact(GetArtifactQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-repository-artifacts")]
        public async Task<IActionResult> GetRepositoryArtifacts(GetRepositoryArtifactsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-repository-workflows")]
        public async Task<IActionResult> GetRepositoryWorkflows(GetRepositoryWorkflowsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-workflow")]
        public async Task<IActionResult> GetWorkflow(GetWorkflowQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-workflow-usage")]
        public async Task<IActionResult> GetWorkflowUsage(GetWorkflowUsageQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
