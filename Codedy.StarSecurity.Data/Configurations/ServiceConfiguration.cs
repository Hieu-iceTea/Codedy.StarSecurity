﻿using Codedy.StarSecurity.Data.Entiies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codedy.StarSecurity.Data.Configurations
{
    class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Service");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Image).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Description).HasColumnType("ntext").IsRequired(true);
            builder.Property(x => x.CategoryId).IsRequired(true);
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)").IsRequired(true);
            builder.Property(x => x.PromotionPrice).HasColumnType("decimal(18,2)").IsRequired(true);
            builder.Property(x => x.IsActive).HasDefaultValue(true).IsRequired(true);
            builder.Property(x => x.DOB).HasColumnType("Date");


            builder.Property(x => x.CreatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.CreatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.UpdatedAt).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdatedBy).HasDefaultValue("Admin");
            builder.Property(x => x.Version).HasDefaultValue(1);
            builder.Property(x => x.Deleted).HasDefaultValue(false);
        }
    }
}