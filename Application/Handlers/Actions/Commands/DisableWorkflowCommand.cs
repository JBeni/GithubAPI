using Application.Common.Models;
using Application.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Actions.Commands
{
    public class DisableWorkflowCommand : IRequest<RequestResponse>
    {
        public Guid Identifier { get; set; }
    }

    public class DisableWorkflowCommandHandler : IRequestHandler<DisableWorkflowCommand, RequestResponse>
    {
        private readonly IActionService _actionService;

        public DisableWorkflowCommandHandler(IActionService actionService)
        {
            _actionService = actionService;
        }

        public async Task<RequestResponse> Handle(DisableWorkflowCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return await _actionService.DisableWorkflow(request);
            }
            catch (Exception ex)
            {
                return RequestResponse.Failure(ex);
            }
        }
    }

    //public class DisableWorkflowCommandValidator : AbstractValidator<DisableWorkflowCommand>
    //{
    //    public DisableWorkflowCommandValidator()
    //    {
    //        RuleFor(v => v.Identifier).Null();
    //    }
    //}
}
