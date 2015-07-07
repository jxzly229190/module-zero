using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using ModuleZeroSampleProject.Navigation.Dto;
using Abp.Domain.Repositories;
using Abp.AutoMapper;

namespace ModuleZeroSampleProject.Navigation
{
    public class NavigationAppService : ApplicationService, INavigationAppService
    {
        private readonly IRepository<Nav> _navReposity;

        public NavigationAppService(IRepository<Nav> navReposity) {
            _navReposity = navReposity;
        }

        public ListResultOutput<NavigationDto> GetNavigations()
        {
            var list = _navReposity.GetAll().ToList();

            return new ListResultOutput<NavigationDto>()
            {
                Items = list.MapTo<List<NavigationDto>>()
            };
        }
    }
}
