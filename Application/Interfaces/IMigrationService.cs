using Application.Handlers.Migrations.Queries;
using Application.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMigrationService
    {
        Task<ImportStatusResponse> GetImportStatus(GetImportStatusQuery query);
        Task<List<UserMigrationResponse>> GetUserMigrations(GetUserMigrationsQuery query);
    }
}
