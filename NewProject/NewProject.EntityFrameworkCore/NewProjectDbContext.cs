using Microsoft.EntityFrameworkCore;
using NewProject.Domain;
using NewProject.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace NewProject.EntityFrameworkCore
{
    [ConnectionStringName(NewProjectDbProperties.ConnectionStringName)]
    public class NewProjectDbContext : AbpDbContext<NewProjectDbContext>
    {
        public DbSet<Project> Project { get; set; }
        public NewProjectDbContext(DbContextOptions<NewProjectDbContext> options) : base(options)
        { 
        
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

           

            /* Configure your own tables/entities inside the ConfigureMyProjectName method */

            builder.ConfigureNewProject();
        }

    }
}
