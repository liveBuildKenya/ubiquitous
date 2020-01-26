using AppApi.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace AppApi.Extensions
{
    public static class FactoriesExtension
    {
        public static void ConfigureApplicationFactories(this IServiceCollection services)
        {
            services.AddTransient<IAlbumFactory, AlbumFactory>();
        }
    }
}