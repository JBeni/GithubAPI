using Application.Handlers.Gitignores.Queries;
using Application.Interfaces;
using Application.Responses;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GitignoreService : CommonService, IGitignoreService
    {
        public async Task<GitignoreTemplateResponse> GetGitignoreTemplate(GetGitignoreTemplateQuery query)
        {
            var response = await _httpClient.GetAsync($"gitignore/templates/{query.Name}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<GitignoreTemplateResponse>(content);
            return result;
        }

        public async Task<List<GitignoreTemplateResponse>> GetGitignoreTemplates(GetGitignoreTemplatesQuery query)
        {
            var response = await _httpClient.GetAsync($"gitignore/templates");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<GitignoreTemplateResponse>>(content);
            return result;
        }
    }
}
