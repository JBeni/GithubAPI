using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Actions.Queries
{
    public class GetWorkflowQuery : IRequest<WorkflowResponse>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
        public int WorkflowId { get; set; }
    }

    public class GetWorkflowQueryHandler : IRequestHandler<GetWorkflowQuery, WorkflowResponse>
    {
        private readonly IActionService _actionService;

        public GetWorkflowQueryHandler(IActionService actionService)
        {
            _actionService = actionService;
        }

        public Task<WorkflowResponse> Handle(GetWorkflowQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _actionService.GetWorkflow(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the repository workflow", ex);
            }
        }
    }
}
