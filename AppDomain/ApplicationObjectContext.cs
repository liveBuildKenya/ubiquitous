using System;
using System.Linq;
using System.Reflection;
using AppDomain.Infrastructure;
using AppDomain.Mappings;
using AppSeed;
using Microsoft.EntityFrameworkCore;

namespace AppDomain
{
    /// <summary>
    /// Represents the application Object context
    /// </summary>
    public partial class ApplicationObjectContext : DbContext, IDbContext
    {
        #region Ctor
        public ApplicationObjectContext(DbContextOptions<ApplicationObjectContext> options) : base(options)
        {

        }

        #endregion

        #region Utilities

        /// <summary>
        /// Further configuration of the model
        /// </summary>
        /// <param name="modelBuilder">Builder being use to construct the context model</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var typeConfigurations = Assembly.GetExecutingAssembly().GetTypes().Where(type =>
            (type.BaseType?.IsGenericType ?? false)
            && (type.BaseType.GetGenericTypeDefinition() == typeof(ApplicationEntityTypeConfiguration<>)));

            foreach (var typeConfiguration in typeConfigurations)
            {
                var configuration = (IMappingConfiguration)Activator.CreateInstance(typeConfiguration);
                configuration.ApplyConfiguration(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }

        #endregion

        #region Methods

        public virtual new DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        #endregion
    }
}