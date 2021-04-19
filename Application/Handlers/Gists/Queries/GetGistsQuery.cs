using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Gists.Queries
{
    public class GetGistsQuery : IRequest<List<GistResponse>>
    {
        public string PersonalGithubToken { get; set; }
    }

    public class GetGistsQueryHandler : IRequestHandler<GetGistsQuery, List<GistResponse>>
    {
        private readonly IGistService _gistService;

        public GetGistsQueryHandler(IGistService gistService)
        {
            _gistService = gistService;
        }

        public Task<List<GistResponse>> Handle(GetGistsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _gistService.GetGists(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the gists", ex);
            }
        }
    }
}
