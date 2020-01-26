using AppApi.Models;
using AppDomain.Models;
using AutoMapper;

namespace AppApi.Extensions
{
    /// <summary>
    /// Represents the mappings
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            ConfigureMappings();
        }

        private void ConfigureMappings()
        {
            CreateMap<Album, AlbumModel>();
            CreateMap<Song, SongModel>();
        }
    }
}