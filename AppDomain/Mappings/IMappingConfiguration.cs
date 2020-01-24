using Microsoft.EntityFrameworkCore;

namespace AppDomain.Mappings
{
    /// <summary>
    /// Represents database context model mapping configuration
    /// </summary>
    public interface IMappingConfiguration
    {
        /// <summary>
        /// Apply this mapping configuration
        /// </summary>
        /// <param name="modelBuilder">Model builder for constructing the database context model</param>
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}