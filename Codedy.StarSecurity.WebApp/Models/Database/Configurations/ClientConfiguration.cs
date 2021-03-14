using Codedy.StarSecurity.WebApp.Models.Database.Entities;
using Codedy.StarSecurity.WebApp.Models.Database.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.WebApp.Models.Database.Configurations
{
    class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).IsRequired(true).HasMaxLength(200);
            builder.Property(x => x.Phone).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Address).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Gender).IsRequired(true).HasDefaultValue(Gender.Male);
            builder.Property(x => x.DOB).HasColumnType("Date").IsRequired(true);
            builder.Property(x => x.FirtName).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(200).IsRequired(true);

            builder.Property(x => x.CreatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.CreatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.UpdatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.Version).HasDefaultValue(1);
            builder.Property(x => x.Deleted).HasDefaultValue(false);
        }
    }
}
