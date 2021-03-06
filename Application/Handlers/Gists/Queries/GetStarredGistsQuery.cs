namespace Application.Handlers.Gists.Queries
{
    public class GetStarredGistsQuery : IRequest<List<GistResponse>>
    {
        public string PersonalGithubToken { get; set; }
    }

    public class GetStarredGistsQueryHandler : IRequestHandler<GetStarredGistsQuery, List<GistResponse>>
    {
        private readonly IGistService _gistService;

        public GetStarredGistsQueryHandler(IGistService gistService)
        {
            _gistService = gistService;
        }

        public Task<List<GistResponse>> Handle(GetStarredGistsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _gistService.GetStarredGists(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the starred gists", ex);
            }
        }
    }
}
