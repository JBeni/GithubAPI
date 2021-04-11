using Application.Handlers.Gists.Queries;
using Application.Interfaces;
using Application.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GistService : IGistService
    {
        public Task<List<GistResponse>> GetGists(GetGistsQuery query)
        {
            throw new System.NotImplementedException();
        }
    }
}
