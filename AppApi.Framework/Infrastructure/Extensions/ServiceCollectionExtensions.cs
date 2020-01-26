using Microsoft.Extensions.DependencyInjection;
using AppServices.Infrastructure.Extensions;

namespace AppApi.Framework.Infrastructure.Extensions
{
    /// <summary>
    /// Represents extensions of IServiceCollection
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.ConfigureAlbumModuleServices();
        }
    }
}