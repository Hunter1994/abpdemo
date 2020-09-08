﻿using AutoMapper;
using demo.Application.Contracts.Projects.Dtos;
using demo.Projects;

namespace demo
{
    public class demoApplicationAutoMapperProfile : Profile
    {
        public demoApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Project, ProjectDto>();
            CreateMap<ProjectCreateDto, Project>();
        }
    }
}
