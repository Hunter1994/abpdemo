using Microsoft.EntityFrameworkCore;
using NewProject.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace NewProject.EntityFrameworkCore
{
    public static class NewProjectDbContextModelBuilderExtensions
    {
        public static void ConfigureNewProject(this ModelBuilder builder)
        {
            builder.Entity<Project>(b =>
            {
                b.ToTable("Projects"); //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureByConvention();

                /* Configure mappings for your additional properties
                 * Also see the MyProjectNameEfCoreEntityExtensionMappings class
                 */
            });

        }


    }
}
