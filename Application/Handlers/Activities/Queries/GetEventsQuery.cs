using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Activities.Queries
{
    public class GetEventsQuery : IRequest<List<EventResponse>>
    {
    }

    public class GetEventsQueryHandler : IRequestHandler<GetEventsQuery, List<EventResponse>>
    {
        private readonly IActivityService _eventService;

        public GetEventsQueryHandler(IActivityService eventService)
        {
            _eventService = eventService;
        }

        public Task<List<EventResponse>> Handle(GetEventsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _eventService.GetEvents(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the events", ex);
            }
        }
    }
}
