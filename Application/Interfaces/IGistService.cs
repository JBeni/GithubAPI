﻿using Application.Handlers.Gists.Queries;
using Application.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGistService
    {
        Task<List<GistResponse>> GetGists(GetGistsQuery query);
        //Task<List<GistResponse>> GetPublicGists(PublicGistsQuery query);
        //Task<List<GistResponse>> GetStarredGists(GetStarredGistsQuery query);
        //Task<List<GistResponse>> GetGist(GetGistQuery query);
        //Task<List<GistResponse>> GetGistCommits(GetGistCommitsQuery query);
    }
}
