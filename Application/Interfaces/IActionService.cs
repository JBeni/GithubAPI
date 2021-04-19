using Application.Handlers.Actions.Queries;
using Application.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IActionService
    {
        Task<ArtifactResponse> GetArtifact(GetArtifactQuery query);
        Task<List<ArtifactResponse>> GetRepositoryArtifacts(GetRepositoryArtifactsQuery query);
        Task<List<WorkflowResponse>> GetRepositoryWorkflows(GetRepositoryWorkflowsQuery query);
        Task<WorkflowResponse> GetWorkflow(GetWorkflowQuery query);
        Task<WorkflowResponse> GetWorkflowUsage(GetWorkflowUsageQuery query);
    }
}
