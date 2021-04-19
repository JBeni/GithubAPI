using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Licenses.Queries
{
    public class GetLicensesQuery : IRequest<List<LicensesResponse>>
    {
    }

    public class GetLicensesQueryHandler : IRequestHandler<GetLicensesQuery, List<LicensesResponse>>
    {
        private readonly ILicenseService _licenseService;

        public GetLicensesQueryHandler(ILicenseService licenseService)
        {
            _licenseService = licenseService;
        }

        public Task<List<LicensesResponse>> Handle(GetLicensesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _licenseService.GetLicenses(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the licenses", ex);
            }
        }
    }
}
