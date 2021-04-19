using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Actions.Queries
{
    public class GetRepositoryWorkflowsQuery : IRequest<List<WorkflowResponse>>
    {
        public string PersonalGithubToken { get; set; }
        public string Owner { get; set; }
        public string Repo { get; set; }
    }

    public class GetRepositoryWorkflowsQueryHandler : IRequestHandler<GetRepositoryWorkflowsQuery, List<WorkflowResponse>>
    {
        private readonly IActionService _actionService;

        public GetRepositoryWorkflowsQueryHandler(IActionService actionService)
        {
            _actionService = actionService;
        }

        public Task<List<WorkflowResponse>> Handle(GetRepositoryWorkflowsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _actionService.GetRepositoryWorkflows(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the repository workflows", ex);
            }
        }
    }
}
