using Application.Handlers.Migrations.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class MigrationsController : ApiControllerBase
    {
        [HttpGet("get-import-status")]
        public async Task<IActionResult> GetImportStatus([FromQuery] GetImportStatusQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("get-user-migrations")]
        public async Task<IActionResult> GetUserMigrations([FromQuery] GetUserMigrationsQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
