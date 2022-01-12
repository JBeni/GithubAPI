namespace Application.Handlers.Activities.Queries
{
    public class GetEventsQuery : IRequest<List<EventResponse>>
    {
    }

    public class GetEventsQueryHandler : IRequestHandler<GetEventsQuery, List<EventResponse>>
    {
        private readonly IActivityService _activityService;

        public GetEventsQueryHandler(IActivityService activityService)
        {
            _activityService = activityService;
        }

        public Task<List<EventResponse>> Handle(GetEventsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _activityService.GetEvents(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the events", ex);
            }
        }
    }
}
