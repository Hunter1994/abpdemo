using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace demo.Application.Contracts.Projects.Dtos
{
    public class GetProjectInput: PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
