using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Application.Services;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using ModuleZeroSampleProject.Navigation;
using Abp.Application.Services.Dto;
using ModuleZeroSampleProject.Navigation.Dto;

namespace ModuleZeroSampleProject.Navigation
{
    public interface INavigationAppService: IApplicationService
    {
        ListResultOutput<NavigationDto> GetNavigations();
    }
}
