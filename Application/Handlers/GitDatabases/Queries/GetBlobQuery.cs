using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.GitDatabases.Queries
{
    public class GetBlobQuery : IRequest<BlobResponse>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
        public string FileSha { get; set; }
    }

    public class GetBlobQueryHandler : IRequestHandler<GetBlobQuery, BlobResponse>
    {
        private readonly IGitDatabaseService _gitDatabaseService;

        public GetBlobQueryHandler(IGitDatabaseService gitDatabaseService)
        {
            _gitDatabaseService = gitDatabaseService;
        }

        public Task<BlobResponse> Handle(GetBlobQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _gitDatabaseService.GetBlob(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the blob", ex);
            }
        }
    }
}
