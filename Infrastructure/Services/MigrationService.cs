using Application.Handlers.Migrations.Queries;
using Application.Interfaces;
using Application.Responses;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MigrationService : CommonService, IMigrationService
    {
        public async Task<ImportStatusResponse> GetImportStatus(GetImportStatusQuery query)
        {
            var response = await _httpClient.GetAsync($"repos/{query.Owner}/{query.Repo}/import");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<ImportStatusResponse>(content);
            return results;
        }

        public async Task<List<UserMigrationResponse>> GetUserMigrations(GetUserMigrationsQuery query)
        {
            var response = await _httpClient.GetAsync($"user/migrations");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<UserMigrationResponse>>(content);
            return results;
        }
    }
}
