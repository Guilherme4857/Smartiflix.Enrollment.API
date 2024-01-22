using Microsoft.EntityFrameworkCore;
using Smartflix.Common.Domain.Context;
using System.Reflection;

namespace Smartflix.Common.Infra.Context
{
    /// <summary>
    /// Implement base context.
    /// </summary>
    public abstract class ContextBase : DbContext, IContextBase
    {
        private readonly Assembly _assembly;

        /// <summary>
        /// Initialize <see cref="ContextBase"/>.
        /// </summary>
        /// <param name="options">Database options.</param>
        public ContextBase(DbContextOptions options, Assembly assembly)
            : base(options)
        {
            _assembly = assembly;
        }

        /// <inheritdoc/>
        protected sealed override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyMappings(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Apply all mappings from assembly.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        protected internal virtual void ApplyMappings(ModelBuilder modelBuilder)
        {
            foreach (var type in _assembly.GetTypes().Where(_ => _.GetInterface(typeof(IEntityTypeConfiguration<>).Name) is not null))
                modelBuilder.ApplyConfiguration((dynamic)Activator.CreateInstance(type));
        }
    }
}
