using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Repositories.Queries
{
    public class GetRepositoryContributorsQuery : IRequest<List<RepositoryContributorResponse>>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
    }

    public class GetRepositoryContributorsQueryHandler : IRequestHandler<GetRepositoryContributorsQuery, List<RepositoryContributorResponse>>
    {
        private readonly IRepositoryService _repositoryService;

        public GetRepositoryContributorsQueryHandler(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        public Task<List<RepositoryContributorResponse>> Handle(GetRepositoryContributorsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _repositoryService.GetRepositoryContributors(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the repository contributors", ex);
            }
        }
    }
}
