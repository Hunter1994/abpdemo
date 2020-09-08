using Microsoft.EntityFrameworkCore;
using NewProject.Domain;
using NewProject.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace NewProject.EntityFrameworkCore.DbMigrations
{
    [ConnectionStringName(NewProjectDbProperties.ConnectionStringName)]
    public class NewProjectMigrationsDbContext : AbpDbContext<NewProjectMigrationsDbContext>
    {
        public NewProjectMigrationsDbContext(DbContextOptions<NewProjectMigrationsDbContext> options)
          : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureNewProject();
        }
    }
}
