using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.GitDatabases.Queries
{
    public class GetReferenceQuery : IRequest<ReferenceResponse>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
        public string Ref { get; set; }
    }

    public class GetReferenceQueryHandler : IRequestHandler<GetReferenceQuery, ReferenceResponse>
    {
        private readonly IGitDatabaseService _gitDatabaseService;

        public GetReferenceQueryHandler(IGitDatabaseService gitDatabaseService)
        {
            _gitDatabaseService = gitDatabaseService;
        }

        public Task<ReferenceResponse> Handle(GetReferenceQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _gitDatabaseService.GetReference(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the reference", ex);
            }
        }
    }
}
