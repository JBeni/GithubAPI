using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Activities.Queries
{
    public class GetOrganizationPublicEventsQuery : IRequest<List<EventResponse>>
    {
        public string Organization { get; set; }
    }

    public class GetOrganizationPublicEventsHandler : IRequestHandler<GetOrganizationPublicEventsQuery, List<EventResponse>>
    {
        private readonly IActivityService _activityService;

        public GetOrganizationPublicEventsHandler(IActivityService activityService)
        {
            _activityService = activityService;
        }

        public Task<List<EventResponse>> Handle(GetOrganizationPublicEventsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _activityService.GetOrganizationPublicEvents(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the organization public events", ex);
            }
        }
    }
}
