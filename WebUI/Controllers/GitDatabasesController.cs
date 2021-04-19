using Application.Handlers.GitDatabases.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class GitDatabasesController : ApiControllerBase
    {
        [HttpGet("get-blob")]
        public async Task<IActionResult> GetBlob(GetBlobQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-commit")]
        public async Task<IActionResult> GetCommit(GetCommitQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-reference")]
        public async Task<IActionResult> GetReference(GetReferenceQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-tag")]
        public async Task<IActionResult> GetTag(GetTagQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
