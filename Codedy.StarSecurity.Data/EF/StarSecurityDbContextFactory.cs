using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Codedy.StarSecurity.Data.EF
{
    class StarSecurityDbContextFactory : IDesignTimeDbContextFactory<StarSecurityDbContext>
    {
        public StarSecurityDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("StarSecurityDb");

            var optionsBuilder = new DbContextOptionsBuilder<StarSecurityDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new StarSecurityDbContext(optionsBuilder.Options);
        }

    }
}
