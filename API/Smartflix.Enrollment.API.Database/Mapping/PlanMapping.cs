using Enrollment.API.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Enrollment.Database.Mapping
{
    internal sealed class PlanMapping : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.ToTable("Plans").HasKey("Name");

            builder.Property(_ => _.Name).HasColumnName("Name").IsRequired().HasMaxLength(200).ValueGeneratedNever();
            builder.Property(_ => _.MonthlyValue).HasColumnName("MonthlyValue").IsRequired();
            builder.Property(_ => _.ClassTotal).HasColumnName("ClassTotal").IsRequired();

            builder.HasMany(_ => _.ClassCategories).WithMany().UsingEntity("PlansClassCategories");
        }
    }
}
