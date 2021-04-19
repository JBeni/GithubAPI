using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Gitignores.Queries
{
    public class GetGitignoreTemplateQuery : IRequest<GitignoreTemplateResponse>
    {
        public string Name { get; set; }
    }

    public class GetGitignoreTemplateQueryHandler : IRequestHandler<GetGitignoreTemplateQuery, GitignoreTemplateResponse>
    {
        private readonly IGitignoreService _gitignoreService;

        public GetGitignoreTemplateQueryHandler(IGitignoreService gitignoreService)
        {
            _gitignoreService = gitignoreService;
        }

        public Task<GitignoreTemplateResponse> Handle(GetGitignoreTemplateQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _gitignoreService.GetGitignoreTemplate(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the gitignore template", ex);
            }
        }
    }
}
