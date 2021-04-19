using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.GitDatabases.Queries
{
    public class GetTagQuery : IRequest<TagResponse>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
        public string TagSha { get; set; }
    }

    public class GetTagQueryHandler : IRequestHandler<GetTagQuery, TagResponse>
    {
        private readonly IGitDatabaseService _gitDatabaseService;

        public GetTagQueryHandler(IGitDatabaseService gitDatabaseService)
        {
            _gitDatabaseService = gitDatabaseService;
        }

        public Task<TagResponse> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _gitDatabaseService.GetTag(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the tag", ex);
            }
        }
    }
}
