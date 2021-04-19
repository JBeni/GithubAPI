using Application.Common.Interfaces;
using Application.Interfaces;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IActivityService, ActivityService>();
            services.AddTransient<IActionService, ActionService>();
            services.AddTransient<IGistService, GistService>();
            services.AddTransient<IGitDatabaseService, GitDatabaseService>();
            services.AddTransient<IGitignoreService, GitignoreService>();
            services.AddTransient<ILicenseService, LicenseService>();
            services.AddTransient<IMigrationService, MigrationService>();
            services.AddTransient<IRepositoryService, RepositoryService>();

            services.AddTransient<IDateTime, DateTimeService>();
            return services;
        }
    }
}
