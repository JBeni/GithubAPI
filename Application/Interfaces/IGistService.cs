namespace Application.Interfaces
{
    public interface IGistService
    {
        Task<List<GistResponse>> GetGists(GetGistsQuery query);
        Task<List<GistResponse>> GetPublicGists(GetPublicGistsQuery query);
        Task<List<GistResponse>> GetStarredGists(GetStarredGistsQuery query);
        Task<GistResponse> GetGist(GetGistQuery query);
        Task<List<GistResponse>> GetGistCommits(GetGistCommitsQuery query);
    }
}
