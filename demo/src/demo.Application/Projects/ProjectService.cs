using Volo.Abp.AutoMapper;
using demo.Application.Contracts.Projects.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Application.Services;

namespace demo.Projects
{
    public class ProjectService :ApplicationService, IProjectService
    {
        private IRepository<Project> _projectRepositoty;
        public ProjectService(IRepository<Project> projectRepositoty)
        {
            _projectRepositoty = projectRepositoty;
        }

        public async Task<ProjectDto> CreateAsync(ProjectCreateDto input)
        {
            var project= ObjectMapper.Map<ProjectCreateDto, Project>(input);
            var projectResult =await _projectRepositoty.InsertAsync(project);
            return ObjectMapper.Map<Project, ProjectDto>(projectResult);
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ProjectDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<ProjectDto>> GetListAsync(GetProjectInput input)
        {
            throw new NotImplementedException();
        }

        public Task<ProjectDto> UpdateAsync(Guid id, ProjectUpdateDto input)
        {
            throw new NotImplementedException();
        }
    }
}
