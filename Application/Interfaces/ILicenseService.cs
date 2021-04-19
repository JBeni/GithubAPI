using Application.Handlers.Licenses.Queries;
using Application.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ILicenseService
    {
        Task<List<LicensesResponse>> GetLicenses(GetLicensesQuery query);
        Task<LicenseExtendResponse> GetLicense(GetLicenseQuery query);
        Task<RepositoryLicenseResponse> GetRepositoryLicense(GetRepositoryLicenseQuery query);
    }
}
