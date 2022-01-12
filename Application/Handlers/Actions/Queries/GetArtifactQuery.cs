namespace Application.Handlers.Actions.Queries
{
    public class GetArtifactQuery : IRequest<ArtifactResponse>
    {
        public string PersonalGithubToken { get; set; }
        public string Owner { get; set; }
        public string Repo { get; set; }
        public int ArtifactId { get; set; }
    }

    public class GetArtifactQueryHandler : IRequestHandler<GetArtifactQuery, ArtifactResponse>
    {
        private readonly IActionService _actionService;

        public GetArtifactQueryHandler(IActionService actionService)
        {
            _actionService = actionService;
        }

        public Task<ArtifactResponse> Handle(GetArtifactQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _actionService.GetArtifact(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the repository artifact", ex);
            }
        }
    }
}
