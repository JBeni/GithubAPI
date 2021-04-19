using Application.Handlers.Actions.Queries;
using Application.Interfaces;
using Application.Responses;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ActionService : CommonService, IActionService
    {
        public async Task<ArtifactResponse> GetArtifact(GetArtifactQuery query)
        {
            var response = await _httpClient.GetAsync($"/repos/{query.Owner}/{query.Repo}/actions/artifacts/{query.ArtifactId}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ArtifactResponse>(content);
            return result;
        }

        public async Task<List<ArtifactResponse>> GetRepositoryArtifacts(GetRepositoryArtifactsQuery query)
        {
            var response = await _httpClient.GetAsync($"/repos/{query.Owner}/{query.Repo}/actions/artifacts");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<ArtifactResponse>>(content);
            return results;
        }

        public async Task<List<WorkflowResponse>> GetRepositoryWorkflows(GetRepositoryWorkflowsQuery query)
        {
            var response = await _httpClient.GetAsync($"/repos/{query.Owner}/{query.Repo}/actions/workflows");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<WorkflowResponse>>(content);
            return results;
        }

        public async Task<WorkflowResponse> GetWorkflow(GetWorkflowQuery query)
        {
            var response = await _httpClient.GetAsync($"/repos/{query.Owner}/{query.Repo}/actions/workflows/{query.WorkflowId}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<WorkflowResponse>(content);
            return result;
        }

        public async Task<WorkflowResponse> GetWorkflowUsage(GetWorkflowUsageQuery query)
        {
            var response = await _httpClient.GetAsync($"/repos/{query.Owner}/{query.Repo}/actions/workflows/{query.WorkflowId}/timing");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<WorkflowResponse>(content);
            return result;
        }
    }
}
