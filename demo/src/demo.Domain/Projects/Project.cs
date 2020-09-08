using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace demo.Projects
{
    public class Project:AuditedAggregateRoot<Guid>
    {
        public string ProjectName { get; set; }
        public ProjectStauts Stauts { get; set; }
        public decimal Cost { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
