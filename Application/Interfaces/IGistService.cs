using Application.Handlers.Gists.Queries;
using Application.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGistService
    {
        Task<List<GistResponse>> GetGists(GetGistsQuery query);
    }
}
