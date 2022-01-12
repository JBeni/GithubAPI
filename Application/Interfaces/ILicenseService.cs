namespace Application.Interfaces
{
    public interface ILicenseService
    {
        Task<List<LicenseExtendResponse>> GetLicenses(GetLicensesQuery query);
        Task<LicenseResponse> GetLicense(GetLicenseQuery query);
        Task<RepositoryLicenseResponse> GetRepositoryLicense(GetRepositoryLicenseQuery query);
    }
}
