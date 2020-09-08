using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NewProject.Domain.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NewProject.EntityFrameworkCore.DbMigrations
{
    public class EntityFrameworkCoreNewProjectDbSchemaMigrator : INewProjectDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreNewProjectDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


        public async Task MigrateAsync()
        {
            await _serviceProvider
                .GetRequiredService<NewProjectMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
