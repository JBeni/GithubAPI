namespace Application.Interfaces
{
    public interface IGitignoreService
    {
        Task<List<GitignoreTemplateResponse>> GetGitignoreTemplates(GetGitignoreTemplatesQuery query);
        Task<GitignoreTemplateResponse> GetGitignoreTemplate(GetGitignoreTemplateQuery query);
    }
}
