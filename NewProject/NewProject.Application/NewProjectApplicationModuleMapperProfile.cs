using AutoMapper;
using NewProject.Application.Contracts.Projects.Dtos;
using NewProject.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewProject.Application
{
    public class NewProjectApplicationModuleMapperProfile:Profile
    {
        public NewProjectApplicationModuleMapperProfile()
        {
            CreateMap<Project, ProjectDto>().MapExtraProperties();
        }
    }
}
