using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ActionsController : ApiControllerBase
    {
        [HttpGet("get-gists")]
        public async Task<IActionResult> GetGists()
        {
            //var result = await Mediator.Send(query);
            return Ok();
        }
    }
}
