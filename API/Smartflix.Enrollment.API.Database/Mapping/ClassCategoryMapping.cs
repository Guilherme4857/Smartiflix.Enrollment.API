using Enrollment.API.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Enrollment.Database.Mapping
{
    internal sealed class ClassCategoryMapping : IEntityTypeConfiguration<ClassCategory>
    {
        public void Configure(EntityTypeBuilder<ClassCategory> builder)
        {
            builder.ToTable("ClassCategories").HasKey(_ => _.Id);

            builder.Property(_ => _.Id).HasColumnName("Id").UseIdentityColumn().ValueGeneratedOnAdd();
            builder.Property(_ => _.Name).HasColumnName("Name").IsRequired().HasMaxLength(100);
            builder.Property(_ => _.Icon).HasColumnName("Icon").IsRequired().HasMaxLength(255);
            builder.Property(_ => _.Description).HasColumnName("Description").IsRequired().HasMaxLength(255);
            builder.Property(_ => _.Teacher).HasColumnName("Teacher").IsRequired().HasMaxLength(255);
        }
    }
}
