namespace Application.Handlers.Licenses.Queries
{
    public class GetLicenseQuery : IRequest<LicenseResponse>
    {
        public string License { get; set; }
    }

    public class GetLicenseQueryHandler : IRequestHandler<GetLicenseQuery, LicenseResponse>
    {
        private readonly ILicenseService _licenseService;

        public GetLicenseQueryHandler(ILicenseService licenseService)
        {
            _licenseService = licenseService;
        }

        public Task<LicenseResponse> Handle(GetLicenseQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _licenseService.GetLicense(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the license", ex);
            }
        }
    }
}
