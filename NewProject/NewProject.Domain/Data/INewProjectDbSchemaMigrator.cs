using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Domain.Data
{
    public interface INewProjectDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
