using Application.Handlers.Repositories.Queries;
using Application.Interfaces;
using Application.Responses;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class RepositoryService : CommonService, IRepositoryService
    {
        public async Task<BranchResponse> GetBranch(GetBranchQuery query)
        {
            var response = await _httpClient.GetAsync($"repos/{query.Owner}/{query.Repo}/branches/{query.Branch}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BranchResponse>(content);
            return result;
        }

        public async Task<List<BranchResponse>> GetBranches(GetBranchesQuery query)
        {
            var response = await _httpClient.GetAsync($"repos/{query.Owner}/{query.Repo}/branches");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<BranchResponse>>(content);
            return results;
        }

        public async Task<List<RepositoryResponse>> GetOrganizationRepositories(GetOrganizationRepositoriesQuery query)
        {
            var response = await _httpClient.GetAsync($"orgs/{query.Organization}/repos");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<RepositoryResponse>>(content);
            return results;
        }

        public async Task<RepositoryResponse> GetRepository(GetRepositoryQuery query)
        {
            var response = await _httpClient.GetAsync($"repos/{query.Owner}/{query.Repo}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<RepositoryResponse>(content);
            return result;
        }

        public async Task<List<RepositoryContributorResponse>> GetRepositoryContributors(GetRepositoryContributorsQuery query)
        {
            var response = await _httpClient.GetAsync($"repos/{query.Owner}/{query.Repo}/contributors");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<RepositoryContributorResponse>>(content);
            return results;
        }
    }
}
