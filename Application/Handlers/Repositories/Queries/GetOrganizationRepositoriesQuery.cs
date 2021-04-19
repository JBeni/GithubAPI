using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Repositories.Queries
{
    public class GetOrganizationRepositoriesQuery : IRequest<List<RepositoryResponse>>
    {
        public string Organization { get; set; }
    }

    public class GetOrganizationRepositoriesQueryHandler : IRequestHandler<GetOrganizationRepositoriesQuery, List<RepositoryResponse>>
    {
        private readonly IRepositoryService _repositoryService;

        public GetOrganizationRepositoriesQueryHandler(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        public Task<List<RepositoryResponse>> Handle(GetOrganizationRepositoriesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _repositoryService.GetOrganizationRepositories(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the organization repository", ex);
            }
        }
    }
}
