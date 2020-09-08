using System;
using System.Collections.Generic;
using System.Text;

namespace NewProject.Domain
{
    public class NewProjectDbProperties
    {
        public static string DbTablePrefix { get; set; } = "NewProject";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "NewProject";
    }
}
