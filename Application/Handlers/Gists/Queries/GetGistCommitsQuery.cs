﻿using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Gists.Queries
{
    public class GetGistCommitsQuery : IRequest<List<GistResponse>>
    {
        public int GistId { get; set; }
    }

    public class GetGistCommitsQueryHandler : IRequestHandler<GetGistCommitsQuery, List<GistResponse>>
    {
        private readonly IGistService _gistService;

        public GetGistCommitsQueryHandler(IGistService gistService)
        {
            _gistService = gistService;
        }

        public Task<List<GistResponse>> Handle(GetGistCommitsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _gistService.GetGistCommits(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the gist commits", ex);
            }
        }
    }
}