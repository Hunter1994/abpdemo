using demo.Projects;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace demo.EntityFrameworkCore
{
    public static class demoDbContextModelCreatingExtensions
    {
        public static void Configuredemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Project>(b =>
            {
                b.ToTable(demoConsts.DbTablePrefix + "Projects", demoConsts.DbSchema);
                b.ConfigureByConvention();
                //...
            });
        }
    }
}