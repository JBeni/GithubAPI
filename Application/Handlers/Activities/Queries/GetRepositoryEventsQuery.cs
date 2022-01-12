namespace Application.Handlers.Activities.Queries
{
    public class GetRepositoryEventsQuery : IRequest<List<EventResponse>>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
    }

    public class GetRepositoryEventsHandler : IRequestHandler<GetRepositoryEventsQuery, List<EventResponse>>
    {
        private readonly IActivityService _activityService;

        public GetRepositoryEventsHandler(IActivityService activityService)
        {
            _activityService = activityService;
        }

        public Task<List<EventResponse>> Handle(GetRepositoryEventsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _activityService.GetRepositoryEvents(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the repository events", ex);
            }
        }
    }
}
