namespace Application.Handlers.Activities.Queries
{
    public class GetUserReceivedPublicEventsQuery : IRequest<List<EventResponse>>
    {
        public string Username { get; set; }
    }

    public class GetUserReceivedPublicEventsQueryHandler : IRequestHandler<GetUserReceivedPublicEventsQuery, List<EventResponse>>
    {
        private readonly IActivityService _activityService;

        public GetUserReceivedPublicEventsQueryHandler(IActivityService activityService)
        {
            _activityService = activityService;
        }

        public Task<List<EventResponse>> Handle(GetUserReceivedPublicEventsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _activityService.GetUserReceivedPublicEvents(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the user received public events", ex);
            }
        }
    }
}
