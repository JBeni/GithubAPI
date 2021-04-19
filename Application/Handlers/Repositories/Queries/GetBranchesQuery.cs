using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Repositories.Queries
{
    public class GetBranchesQuery : IRequest<List<BranchResponse>>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
    }

    public class GetBranchesQueryHandler : IRequestHandler<GetBranchesQuery, List<BranchResponse>>
    {
        private readonly IRepositoryService _repositoryService;

        public GetBranchesQueryHandler(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        public Task<List<BranchResponse>> Handle(GetBranchesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _repositoryService.GetBranches(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the branches", ex);
            }
        }
    }
}
