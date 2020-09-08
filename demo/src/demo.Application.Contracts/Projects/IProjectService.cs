using demo.Application.Contracts.Projects.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace demo.Projects
{
    public interface IProjectService : ICrudAppService<ProjectDto, Guid, GetProjectInput, ProjectCreateDto, ProjectUpdateDto>
    {

    }
}
