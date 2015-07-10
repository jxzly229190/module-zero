using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleZeroSampleProject.Authorization.Dto
{
    public class GrantUserInput:IInputDto
    {
        [Required]
        public long PermissionId { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
