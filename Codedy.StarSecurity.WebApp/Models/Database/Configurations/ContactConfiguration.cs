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
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.ID);

            builder.Property(x => x.FullName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Subject).IsRequired();
            builder.Property(x => x.Message).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(Status.Processing);

            builder.Property(x => x.CreatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.CreatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.UpdatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.Version).HasDefaultValue(1);
            builder.Property(x => x.Deleted).HasDefaultValue(false);
        }
    }
}
