using Application.Common.Models;
using Application.Handlers.Actions.Commands;
using Application.Handlers.Actions.Queries;
using Application.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IActionService
    {
        Task<ArtifactResponse> GetArtifact(GetArtifactQuery query);
        Task<RequestResponse> DisableWorkflow(DisableWorkflowCommand command);
        Task<RequestResponse> EnableWorkflow(EnableWorkflowCommand command);
        Task<List<ArtifactResponse>> GetRepositoryArtifacts(GetRepositoryArtifactsQuery query);
        Task<List<WorkflowResponse>> GetRepositoryWorkflows(GetRepositoryWorkflowsQuery query);
        Task<WorkflowResponse> GetWorkflow(GetWorkflowQuery query);
        Task<WorkflowResponse> GetWorkflowUsage(GetWorkflowUsageQuery query);
    }
}
