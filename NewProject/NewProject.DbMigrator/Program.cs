using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace NewProject.DbMigrator
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).RunConsoleAsync();
        }
        public static IHostBuilder CreateHostBuilder(string[] args)=>
             Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<DbMigratorHostedService>();
                });
    }
}
