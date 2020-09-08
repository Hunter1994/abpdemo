using NewProject.Domain.Shared.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace NewProject.Application.Contracts.Projects.Dtos
{
    public class ProjectDto: ExtensibleFullAuditedEntityDto<Guid>
    {
        public string ProjectName { get; set; }
        public ProjectStauts Stauts { get; set; }
        public decimal Cost { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
