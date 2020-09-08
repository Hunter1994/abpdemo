using demo.Projects;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace demo.Application.Contracts.Projects.Dtos
{
    public class ProjectUpdateDto
    {
        [Required]
        [MaxLength(ProjectConsts.MaxProjectNameLength)]
        public string ProjectName { get; set; }
    }
}
