using Application.Interfaces;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Migrations.Queries
{
    public class GetUserMigrationsQuery : IRequest<List<UserMigrationResponse>>
    {
    }

    public class GetUserMigrationsQueryHandler : IRequestHandler<GetUserMigrationsQuery, List<UserMigrationResponse>>
    {
        private readonly IMigrationService _migrationService;

        public GetUserMigrationsQueryHandler(IMigrationService migrationService)
        {
            _migrationService = migrationService;
        }

        public Task<List<UserMigrationResponse>> Handle(GetUserMigrationsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _migrationService.GetUserMigrations(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the user migrations", ex);
            }
        }
    }
}
