using Application.Handlers.Licenses.Queries;
using Application.Interfaces;
using Application.Responses;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class LicenseService : CommonService, ILicenseService
    {
        public async Task<LicenseResponse> GetLicense(GetLicenseQuery query)
        {
            var response = await _httpClient.GetAsync($"licenses/{query.License}");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<LicenseResponse>(content);
            return result;
        }

        public async Task<List<LicensesResponse>> GetLicenses(GetLicensesQuery query)
        {
            var response = await _httpClient.GetAsync($"licenses");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<LicensesResponse>>(content);
            return results;
        }

        public async Task<RepositoryLicenseResponse> GetRepositoryLicense(GetRepositoryLicenseQuery query)
        {
            var response = await _httpClient.GetAsync($"repos/{query.Owner}/{query.Repo}/license");
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<RepositoryLicenseResponse>(content);
            return result;
        }
    }
}
