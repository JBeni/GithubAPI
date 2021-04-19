using Application.Handlers.Licenses.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class LicensesController : ApiControllerBase
    {
        [HttpGet("get-licenses")]
        public async Task<IActionResult> GetLicenses([FromQuery] GetLicensesQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-license")]
        public async Task<IActionResult> GetLicense([FromQuery] GetLicenseQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-repository-license")]
        public async Task<IActionResult> GetRepositoryLicense([FromQuery] GetRepositoryLicenseQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
