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
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.Email).IsRequired(true).HasMaxLength(200);
            builder.Property(x => x.Phone).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Address).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Gender).IsRequired(true).HasDefaultValue(Gender.Male);
            builder.Property(x => x.DOB).HasColumnType("Date").IsRequired(true);
            builder.Property(x => x.FirtName).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.LastName).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.EmployeeEducationalQualification).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.EmployeeDepartment).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.EmployeeCode).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.EmployeeRole).HasMaxLength(100);
            builder.Property(x => x.EmployeeGrade).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.EmployeeAchievements).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.LastLoginDate).HasColumnType("Date").IsRequired(true);


            builder.Property(x => x.CreatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.CreatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.UpdatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.Version).HasDefaultValue(1);
            builder.Property(x => x.Deleted).HasDefaultValue(false);

        }
    }
}
