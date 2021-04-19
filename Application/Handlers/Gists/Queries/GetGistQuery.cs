using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Gists.Queries
{
    public class GetGistQuery : IRequest<GistResponse>
    {
        public string PersonalGithubToken { get; set; }
        public int GistId { get; set; }
    }

    public class GetGistQueryHandler : IRequestHandler<GetGistQuery, GistResponse>
    {
        private readonly IGistService _gistService;

        public GetGistQueryHandler(IGistService gistService)
        {
            _gistService = gistService;
        }

        public Task<GistResponse> Handle(GetGistQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _gistService.GetGist(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the gist", ex);
            }
        }
    }
}
