namespace Application.Interfaces
{
    public interface IRepositoryService
    {
        Task<List<RepositoryResponse>> GetOrganizationRepositories(GetOrganizationRepositoriesQuery query);
        Task<RepositoryResponse> GetRepository(GetRepositoryQuery query);
        Task<List<RepositoryContributorResponse>> GetRepositoryContributors(GetRepositoryContributorsQuery query);
        Task<List<BranchResponse>> GetBranches(GetBranchesQuery query);
        Task<BranchResponse> GetBranch(GetBranchQuery query);
    }
}
