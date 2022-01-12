namespace Application.Handlers.GitDatabases.Queries
{
    public class GetCommitQuery : IRequest<CommitResponse>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
        public string CommitSha { get; set; }
    }

    public class GetCommitQueryHandler : IRequestHandler<GetCommitQuery, CommitResponse>
    {
        private readonly IGitDatabaseService _gitDatabaseService;

        public GetCommitQueryHandler(IGitDatabaseService gitDatabaseService)
        {
            _gitDatabaseService = gitDatabaseService;
        }

        public Task<CommitResponse> Handle(GetCommitQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _gitDatabaseService.GetCommit(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the commit", ex);
            }
        }
    }
}
