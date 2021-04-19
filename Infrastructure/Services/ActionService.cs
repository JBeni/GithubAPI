using Application.Common.Models;
using Application.Handlers.Actions.Commands;
using Application.Handlers.Actions.Queries;
using Application.Interfaces;
using Application.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ActionService : CommonService, IActionService
    {
        public Task<RequestResponse> DisableWorkflow(DisableWorkflowCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<RequestResponse> EnableWorkflow(EnableWorkflowCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<ArtifactResponse> GetArtifact(GetArtifactQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArtifactResponse>> GetRepositoryArtifacts(GetRepositoryArtifactsQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<List<WorkflowResponse>> GetRepositoryWorkflows(GetRepositoryWorkflowsQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<WorkflowResponse> GetWorkflow(GetWorkflowQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<WorkflowResponse> GetWorkflowUsage(GetWorkflowUsageQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
