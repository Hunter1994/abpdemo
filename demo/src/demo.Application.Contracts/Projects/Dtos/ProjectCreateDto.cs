using demo.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace demo.Application.Contracts.Projects.Dtos
{
    public class ProjectCreateDto
    {
        [Required]
        [MaxLength(ProjectConsts.MaxProjectNameLength)]
        public string ProjectName { get; set; }
        public ProjectStauts Stauts { get; set; }
        public decimal Cost { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
