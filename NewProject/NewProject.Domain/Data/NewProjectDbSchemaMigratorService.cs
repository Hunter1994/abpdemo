using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace NewProject.Domain.Data
{
    public class NewProjectDbSchemaMigratorService :ITransientDependency
    {

        private readonly IDataSeeder _dataSeeder;
        private readonly IEnumerable<INewProjectDbSchemaMigrator> _dbSchemaMigrators;

        public NewProjectDbSchemaMigratorService(
            IDataSeeder dataSeeder,
            IEnumerable<INewProjectDbSchemaMigrator> dbSchemaMigrators)
        {
            _dataSeeder = dataSeeder;
            _dbSchemaMigrators = dbSchemaMigrators;
        }

        public async Task MigrateAsync()
        {
            await MigrateDatabaseSchemaAsync();
            await SeedDataAsync();

        }

        private async Task MigrateDatabaseSchemaAsync()
        {

            foreach (var migrator in _dbSchemaMigrators)
            {
                await migrator.MigrateAsync();
            }
        }

        private async Task SeedDataAsync()
        {
            await _dataSeeder.SeedAsync();
        }
    }
}
