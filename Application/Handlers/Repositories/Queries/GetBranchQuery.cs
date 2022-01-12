namespace Application.Handlers.Repositories.Queries
{
    public class GetBranchQuery : IRequest<BranchResponse>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
        public string Branch { get; set; }
    }

    public class GetBranchQueryHandler : IRequestHandler<GetBranchQuery, BranchResponse>
    {
        private readonly IRepositoryService _repositoryService;

        public GetBranchQueryHandler(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        public Task<BranchResponse> Handle(GetBranchQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _repositoryService.GetBranch(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the branch", ex);
            }
        }
    }
}
