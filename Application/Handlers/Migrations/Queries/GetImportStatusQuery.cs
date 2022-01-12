namespace Application.Handlers.Migrations.Queries
{
    public class GetImportStatusQuery : IRequest<ImportStatusResponse>
    {
        public string Owner { get; set; }
        public string Repo { get; set; }
    }

    public class GetImportStatusQueryHandler : IRequestHandler<GetImportStatusQuery, ImportStatusResponse>
    {
        private readonly IMigrationService _migrationService;

        public GetImportStatusQueryHandler(IMigrationService migrationService)
        {
            _migrationService = migrationService;
        }

        public Task<ImportStatusResponse> Handle(GetImportStatusQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = _migrationService.GetImportStatus(request);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error retrieving the import status", ex);
            }
        }
    }
}
