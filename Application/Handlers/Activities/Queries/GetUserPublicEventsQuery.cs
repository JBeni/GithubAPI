using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Activities.Queries
{
    public class GetUserPublicEventsQuery : IRequest<List<EventResponse>>
    {
        public string Username { get; set; }
    }

    public class GetUserPublicEventsHandler : IRequestHandler<GetUserPublicEventsQuery, List<EventResponse>>
    {
        private readonly IActivityService _activityService;

        public GetUserPublicEventsHandler(IActivityService activityService)
        {
            _activityService = activityService;
        }

        public Task<List<EventResponse>> Handle(GetUserPublicEventsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _activityService.GetUserPublicEvents(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the user public events", ex);
            }
        }
    }
}
