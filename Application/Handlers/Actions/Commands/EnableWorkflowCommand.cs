using Application.Common.Models;
using Application.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Actions.Commands
{
    public class EnableWorkflowCommand : IRequest<RequestResponse>
    {
        public Guid Identifier { get; set; }
    }

    public class EnableWorkflowCommandHandler : IRequestHandler<EnableWorkflowCommand, RequestResponse>
    {
        private readonly IActionService _actionService;

        public EnableWorkflowCommandHandler(IActionService actionService)
        {
            _actionService = actionService;
        }

        public async Task<RequestResponse> Handle(EnableWorkflowCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return await _actionService.EnableWorkflow(request);
            }
            catch (Exception ex)
            {
                return RequestResponse.Failure(ex);
            }
        }
    }

    //public class EnableWorkflowCommandValidator : AbstractValidator<EnableWorkflowCommand>
    //{
    //    public EnableWorkflowCommandValidator()
    //    {
    //        RuleFor(v => v.Identifier).Null();
    //    }
    //}
}
