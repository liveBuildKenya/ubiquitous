using AppDomain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppDomain.Mappings.ModelsMapping
{
    public partial class AlbumMap : ApplicationEntityTypeConfiguration<Album>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">Builder being used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable(nameof(Song));
            builder.HasKey(a => a.Id);
        }   
    }
}