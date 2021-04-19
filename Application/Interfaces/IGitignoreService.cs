using Application.Handlers.Gitignores.Queries;
using Application.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGitignoreService
    {
        Task<List<GitignoreTemplateResponse>> GetGitignoreTemplates(GetGitignoreTemplatesQuery query);
        Task<GitignoreTemplateResponse> GetGitignoreTemplate(GetGitignoreTemplateQuery query);
    }
}
