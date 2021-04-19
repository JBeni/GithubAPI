using Application.Handlers.Licenses.Queries;
using Application.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ILicenseService
    {
        Task<List<LicenseExtendResponse>> GetLicenses(GetLicensesQuery query);
        Task<LicenseResponse> GetLicense(GetLicenseQuery query);
        Task<RepositoryLicenseResponse> GetRepositoryLicense(GetRepositoryLicenseQuery query);
    }
}
