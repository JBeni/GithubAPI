namespace Application.Handlers.Repositories.Queries
{
    public class GetRepositoryQuery : IRequest<RepositoryResponse>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
    }

    public class GetRepositoryQueryHandler : IRequestHandler<GetRepositoryQuery, RepositoryResponse>
    {
        private readonly IRepositoryService _repositoryService;

        public GetRepositoryQueryHandler(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        public Task<RepositoryResponse> Handle(GetRepositoryQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _repositoryService.GetRepository(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the repository", ex);
            }
        }
    }
}
