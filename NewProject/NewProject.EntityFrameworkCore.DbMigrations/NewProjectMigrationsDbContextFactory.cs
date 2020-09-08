using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NewProject.EntityFrameworkCore.DbMigrations
{
    public class NewProjectMigrationsDbContextFactory: IDesignTimeDbContextFactory<NewProjectMigrationsDbContext>
    {
        public NewProjectMigrationsDbContext CreateDbContext(string[] args)
        {
            //MyProjectNameEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<NewProjectMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("NewProject"));

            return new NewProjectMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }


    }
}
