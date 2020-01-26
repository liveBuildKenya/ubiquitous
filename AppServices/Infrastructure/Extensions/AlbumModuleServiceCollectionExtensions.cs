using AppServices.Service;
using Microsoft.Extensions.DependencyInjection;

namespace AppServices.Infrastructure.Extensions
{
    /// <summary>
    /// Represents Album module service collection extension
    /// </summary>
    public static class AlbumModuleServiceCollectionExtensions
    {
        public static void ConfigureAlbumModuleServices(this IServiceCollection services)
        {
            services.AddTransient<IAlbumService, AlbumService>();
        }
    }
}