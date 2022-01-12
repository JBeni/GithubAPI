namespace Application.Interfaces
{
    public interface IMigrationService
    {
        Task<ImportStatusResponse> GetImportStatus(GetImportStatusQuery query);
        Task<List<UserMigrationResponse>> GetUserMigrations(GetUserMigrationsQuery query);
    }
}
