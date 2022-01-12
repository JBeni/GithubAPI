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

        public async Task<List<LicenseExtendResponse>> GetLicenses(GetLicensesQuery query)
        {
            var response = await _httpClient.GetAsync($"licenses");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<List<LicenseExtendResponse>>(content);
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
