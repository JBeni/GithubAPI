using Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ActionsController : ApiControllerBase
    {
        protected HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public ActionsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("get-gists")]
        public async Task<IActionResult> GetGists()
        {
            var response = await _httpClient.GetAsync("gists");
            var content = await response.Content.ReadAsStringAsync();
            var gists = JsonConvert.DeserializeObject<List<GistResponse>>(content);
            return Ok();
        }
    }
}
