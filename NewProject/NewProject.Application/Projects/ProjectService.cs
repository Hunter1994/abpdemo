using NewProject.Application.Contracts.Projects;
using NewProject.Application.Contracts.Projects.Dtos;
using NewProject.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewProject.Application.Projects
{
    public class ProjectService : ApplicationService, IProjectService
    {

        private IRepository<Project> _projectRepositoty;
        public ProjectService(IRepository<Project> projectRepositoty)
        {
            _projectRepositoty = projectRepositoty;
        }

        public async Task<ProjectDto> CreateAsync(ProjectCreateDto input)
        {
            var project = ObjectMapper.Map<ProjectCreateDto, Project>(input);
            var projectResult = await _projectRepositoty.InsertAsync(project);
            return ObjectMapper.Map<Project, ProjectDto>(projectResult);
        }

        public async Task DeleteAsync(Guid id)
        {
            Console.WriteLine("添加");
        }

        public async Task<ProjectDto> GetAsync(Guid id)
        {
            return new ProjectDto() { ProjectName= "诸暨祥生祥韵置业有限公司祥生云境花园A1-A3#楼A5-A11#楼B3B5-B6#楼B8-B13#楼B15-B17#楼C1-C3#楼C5-C13#楼C15-C18#楼及地下室"};
        }

        public async Task<PagedResultDto<ProjectDto>> GetListAsync(GetProjectInput input)
        {
            return new PagedResultDto<ProjectDto>();
        }

        public async Task<ProjectDto> UpdateAsync(Guid id, ProjectUpdateDto input)
        {
            return new ProjectDto();
        }
    }
}
