﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Smartflix.Enrollment.Database.Entities;
using Smartflix.Enrollment.Domain.Enum;

namespace Smartflix.Enrollment.Database.Mapping
{
    /// <summary>
    /// User mapping.
    /// </summary>
    public sealed class UserMapping : IEntityTypeConfiguration<User>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User").HasKey(_ => _.Id);

            builder.Property(_ => _.Role).IsRequired().HasConversion(new EnumToStringConverter<RoleEnum>());
            builder.Property(_ => _.Name).HasColumnName("UserName").IsRequired();
            builder.Property(_ => _.Email).IsRequired();
            builder.Property(_ => _.Password).IsRequired();
        }
    }
}
