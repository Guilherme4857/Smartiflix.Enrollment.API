using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smartflix.Enrollment.Database.Entities;

namespace Smartflix.Enrollment.Database.Mapping
{
    public sealed class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User").HasKey(_ => _.Id);

            builder.Property(_ => _.Name).HasColumnName("UserName").IsRequired();
            builder.Property(_ => _.Email).IsRequired();
            builder.Property(_ => _.Password).IsRequired();
        }
    }
}
