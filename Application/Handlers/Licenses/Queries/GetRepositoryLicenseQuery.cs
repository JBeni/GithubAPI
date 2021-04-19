using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Licenses.Queries
{
    public class GetRepositoryLicenseQuery : IRequest<RepositoryLicenseResponse>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
    }

    public class GetRepositoryLicenseQueryHandler : IRequestHandler<GetRepositoryLicenseQuery, RepositoryLicenseResponse>
    {
        private readonly ILicenseService _licenseService;

        public GetRepositoryLicenseQueryHandler(ILicenseService licenseService)
        {
            _licenseService = licenseService;
        }

        public Task<RepositoryLicenseResponse> Handle(GetRepositoryLicenseQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _licenseService.GetRepositoryLicense(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the repository license", ex);
            }
        }
    }}
