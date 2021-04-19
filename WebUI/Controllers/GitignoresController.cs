using Application.Handlers.Gitignores.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class GitignoresController : ApiControllerBase
    {
        [HttpGet("get-gitignore-templates")]
        public async Task<IActionResult> GetGitignoreTemplates([FromQuery] GetGitignoreTemplatesQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-gitignore-template")]
        public async Task<IActionResult> GetGitignoreTemplate([FromQuery] GetGitignoreTemplateQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
