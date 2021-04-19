using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Actions.Queries
{
    public class GetRepositoryArtifactsQuery : IRequest<List<ArtifactResponse>>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
    }

    public class GetRepositoryArtifactsQueryHandler : IRequestHandler<GetRepositoryArtifactsQuery, List<ArtifactResponse>>
    {
        private readonly IActionService _actionService;

        public GetRepositoryArtifactsQueryHandler(IActionService actionService)
        {
            _actionService = actionService;
        }

        public Task<List<ArtifactResponse>> Handle(GetRepositoryArtifactsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _actionService.GetRepositoryArtifacts(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the repository artifacts", ex);
            }
        }
    }
}
