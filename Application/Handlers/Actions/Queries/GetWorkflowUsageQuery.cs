using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Actions.Queries
{
    public class GetWorkflowUsageQuery : IRequest<WorkflowUsageResponse>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
        public int WorkflowId { get; set; }
    }

    public class GetWorkflowUsageQueryHandler : IRequestHandler<GetWorkflowUsageQuery, WorkflowUsageResponse>
    {
        private readonly IActionService _actionService;

        public GetWorkflowUsageQueryHandler(IActionService actionService)
        {
            _actionService = actionService;
        }

        public Task<WorkflowUsageResponse> Handle(GetWorkflowUsageQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _actionService.GetWorkflowUsage(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the repository workflow usage", ex);
            }
        }
    }
}
