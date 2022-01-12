namespace Application.Handlers.Activities.Queries
{
    public class GetNetworkPublicEventsQuery : IRequest<List<EventResponse>>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
    }

    public class GetNetworkPublicEventsHandler : IRequestHandler<GetNetworkPublicEventsQuery, List<EventResponse>>
    {
        private readonly IActivityService _activityService;

        public GetNetworkPublicEventsHandler(IActivityService activityService)
        {
            _activityService = activityService;
        }

        public Task<List<EventResponse>> Handle(GetNetworkPublicEventsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _activityService.GetNetworkPublicEvents(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the network public events", ex);
            }
        }
    }
}
