namespace Application.Handlers.Gists.Queries
{
    public class GetPublicGistsQuery : IRequest<List<GistResponse>>
    {
    }

    public class GetPublicGistsQueryHandler : IRequestHandler<GetPublicGistsQuery, List<GistResponse>>
    {
        private readonly IGistService _gistService;

        public GetPublicGistsQueryHandler(IGistService gistService)
        {
            _gistService = gistService;
        }

        public Task<List<GistResponse>> Handle(GetPublicGistsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _gistService.GetPublicGists(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the public gists", ex);
            }
        }
    }
}
