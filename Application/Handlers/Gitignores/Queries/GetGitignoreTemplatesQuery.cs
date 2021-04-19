using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Gitignores.Queries
{
    public class GetGitignoreTemplatesQuery : IRequest<List<GitignoreTemplateResponse>>
    {
    }

    public class GetGitignoreTemplatesQueryHandler : IRequestHandler<GetGitignoreTemplatesQuery, List<GitignoreTemplateResponse>>
    {
        private readonly IGitignoreService _gitignoreService;

        public GetGitignoreTemplatesQueryHandler(IGitignoreService gitignoreService)
        {
            _gitignoreService = gitignoreService;
        }

        public Task<List<GitignoreTemplateResponse>> Handle(GetGitignoreTemplatesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _gitignoreService.GetGitignoreTemplates(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the gitignore templates", ex);
            }
        }
    }
}
