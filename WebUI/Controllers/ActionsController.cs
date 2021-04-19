using Application.Handlers.Actions.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ActionsController : ApiControllerBase
    {
        [HttpGet("get-artifact")]
        public async Task<IActionResult> GetArtifact([FromQuery] GetArtifactQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-repository-artifacts")]
        public async Task<IActionResult> GetRepositoryArtifacts([FromQuery] GetRepositoryArtifactsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-repository-workflows")]
        public async Task<IActionResult> GetRepositoryWorkflows([FromQuery] GetRepositoryWorkflowsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-workflow")]
        public async Task<IActionResult> GetWorkflow([FromQuery] GetWorkflowQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-workflow-usage")]
        public async Task<IActionResult> GetWorkflowUsage([FromQuery] GetWorkflowUsageQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
