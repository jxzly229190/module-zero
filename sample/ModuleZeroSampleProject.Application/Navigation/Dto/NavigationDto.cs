using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleZeroSampleProject.Navigation.Dto
{
    [AutoMapFrom(typeof(Nav))]
    public class NavigationDto:FullAuditedEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
