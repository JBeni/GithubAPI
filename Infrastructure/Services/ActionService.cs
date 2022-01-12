namespace Infrastructure.Services
{
    public class ActionService : CommonService, IActionService
    {
        public async Task<ArtifactResponse> GetArtifact(GetArtifactQuery query)
        {
            AuthenticateUserWithPersonalToken(_httpClient, query.PersonalGithubToken);
            var response = await _httpClient.GetAsync($"/repos/{query.Owner}/{query.Repo}/actions/artifacts/{query.ArtifactId}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ArtifactResponse>(content);
            return result;
        }

        public async Task<List<ArtifactResponse>> GetRepositoryArtifacts(GetRepositoryArtifactsQuery query)
        {
            AuthenticateUserWithPersonalToken(_httpClient, query.PersonalGithubToken);
            var response = await _httpClient.GetAsync($"/repos/{query.Owner}/{query.Repo}/actions/artifacts");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<ArtifactResponse>>(content);
            return results;
        }

        public async Task<List<WorkflowResponse>> GetRepositoryWorkflows(GetRepositoryWorkflowsQuery query)
        {
            AuthenticateUserWithPersonalToken(_httpClient, query.PersonalGithubToken);
            var response = await _httpClient.GetAsync($"/repos/{query.Owner}/{query.Repo}/actions/workflows");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<WorkflowResponse>>(content);
            return results;
        }

        public async Task<WorkflowResponse> GetWorkflow(GetWorkflowQuery query)
        {
            AuthenticateUserWithPersonalToken(_httpClient, query.PersonalGithubToken);
            var response = await _httpClient.GetAsync($"/repos/{query.Owner}/{query.Repo}/actions/workflows/{query.WorkflowId}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<WorkflowResponse>(content);
            return result;
        }

        public async Task<WorkflowUsageResponse> GetWorkflowUsage(GetWorkflowUsageQuery query)
        {
            AuthenticateUserWithPersonalToken(_httpClient, query.PersonalGithubToken);
            var response = await _httpClient.GetAsync($"/repos/{query.Owner}/{query.Repo}/actions/workflows/{query.WorkflowId}/timing");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<WorkflowUsageResponse>(content);
            return result;
        }
    }
}
