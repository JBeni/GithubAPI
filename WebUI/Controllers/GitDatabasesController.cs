using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class GitDatabasesController : ApiControllerBase
    {
        [HttpGet("get-gists")]
        public async Task<IActionResult> GetGists()
        {
            return Ok();
        }
    }
}
