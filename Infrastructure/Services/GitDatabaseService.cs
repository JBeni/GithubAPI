using Application.Handlers.GitDatabases.Queries;
using Application.Interfaces;
using Application.Responses;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GitDatabaseService : CommonService, IGitDatabaseService
    {
        public async Task<BlobResponse> GetBlob(GetBlobQuery query)
        {
            var response = await _httpClient.GetAsync($"repos/{query.Owner}/{query.Repo}/git/blobs/{query.FileSha}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BlobResponse>(content);
            return result;
        }

        public async Task<CommitResponse> GetCommit(GetCommitQuery query)
        {
            var response = await _httpClient.GetAsync($"repos/{query.Owner}/{query.Repo}/git/commits/{query.CommitSha}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<CommitResponse>(content);
            return result;
        }

        public async Task<ReferenceResponse> GetReference(GetReferenceQuery query)
        {
            var response = await _httpClient.GetAsync($"repos/{query.Owner}/{query.Repo}/git/ref/{query.Ref}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ReferenceResponse>(content);
            return result;
        }

        public async Task<TagResponse> GetTag(GetTagQuery query)
        {
            var response = await _httpClient.GetAsync($"repos/{query.Owner}/{query.Repo}/git/tags/{query.TagSha}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TagResponse>(content);
            return result;
        }
    }
}
