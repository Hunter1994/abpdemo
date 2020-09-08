using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NewProject.Domain.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp;

namespace NewProject.DbMigrator
{
    public class DbMigratorHostedService : IHostedService
    {

        private readonly IHostApplicationLifetime _hostApplicationLifetime;

        public DbMigratorHostedService(IHostApplicationLifetime hostApplicationLifetime)
        {
            _hostApplicationLifetime = hostApplicationLifetime;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using (var application = AbpApplicationFactory.Create<NewProjectDbMigratorModule>(options =>
            {
                options.UseAutofac();
            }))
            {
                application.Initialize();

                try
                {
                    await application
                    .ServiceProvider
                    .GetRequiredService<NewProjectDbSchemaMigratorService>()
                    .MigrateAsync();
                }
                catch (Exception ex)
                {

                    throw;
                }
                

                application.Shutdown();

                _hostApplicationLifetime.StopApplication();
            }
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;

    }
}
