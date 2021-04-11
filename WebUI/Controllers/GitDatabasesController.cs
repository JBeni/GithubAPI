using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class GitDatabasesController : ApiControllerBase
    {
        [HttpGet("get-gists")]
        public async Task<IActionResult> GetGists()
        {
            //var response = await _httpClient.GetAsync("gists");
            //var content = await response.Content.ReadAsStringAsync();
            //var gists = JsonConvert.DeserializeObject<List<Gist>>(content);
            return Ok();
        }
    }
}
