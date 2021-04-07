using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Database.Configurations
{
    class CarrerConfiguration : IEntityTypeConfiguration<Career>
    {
        public void Configure(EntityTypeBuilder<Career> builder)
        {
            builder.ToTable("Careers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired(true).HasMaxLength(200);
            builder.Property(x => x.Image).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Salary).IsRequired(true).HasMaxLength(50);
            builder.Property(x => x.Description).HasColumnType("text").IsRequired(true);
            builder.Property(x => x.WorkAddress).IsRequired(true).HasMaxLength(200);
            builder.Property(x => x.ExpirationDate).IsRequired(true);

            builder.Property(x => x.CreatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.CreatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.UpdatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.Version).HasDefaultValue(1);
            builder.Property(x => x.Deleted).HasDefaultValue(false);
        }
    }
}
