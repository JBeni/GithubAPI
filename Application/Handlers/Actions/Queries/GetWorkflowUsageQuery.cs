using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Actions.Queries
{
    public class GetWorkflowUsageQuery : IRequest<WorkflowResponse>
    {
        public int WorkflowId { get; set; }
    }

    public class GetWorkflowUsageQueryHandler : IRequestHandler<GetWorkflowUsageQuery, WorkflowResponse>
    {
        private readonly IActionService _actionService;

        public GetWorkflowUsageQueryHandler(IActionService actionService)
        {
            _actionService = actionService;
        }

        public Task<WorkflowResponse> Handle(GetWorkflowUsageQuery request, CancellationToken cancellationToken)
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
