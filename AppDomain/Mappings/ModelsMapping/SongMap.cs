using AppDomain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppDomain.Mappings.ModelsMapping
{
    /// <summary>
    /// Represents a Song mapping configuration
    /// </summary>
    public partial class SongMap : ApplicationEntityTypeConfiguration<Song>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">Builder being used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable(nameof(Song));
            builder.HasKey(s => s.Id);
        }
    }
}