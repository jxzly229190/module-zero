using Abp.Authorization.Roles;
using Abp.Domain.Repositories;
using ModuleZeroSampleProject.Authorization;
using ModuleZeroSampleProject.Authorization.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ModuleZeroSampleProject.Tests.Authorization
{
    public class PermissionAppService_Test : SampleProjectTestBase
    {
        private readonly IPermissionAppService _permissionAppService;

        public PermissionAppService_Test()
        {
            _permissionAppService = LocalIocManager.Resolve<IPermissionAppService>();
            //_rolePermission = LocalIocManager.Resolve<RolePermissionSetting>();
        }

        [Fact]
        public void Should_Grant_Role_Permission()
        {
            _permissionAppService.GrantRole(new GrantRoleInput() { PermissionName = "CanAnswerToQuestions", RoleId = 3 });

            this.UsingDbContext(context => {
                context.RolePermissions.Where(p => p.RoleId == 3).Count().ShouldBe(2);
                var permission = context.RolePermissions.FirstOrDefault(p => p.Name == "CanAnswerToQuestions");

                permission.ShouldNotBe(null);
                permission.RoleId.ShouldBe(3);
            });

            //this.UsingDbContext(context=>context)
        }
    }
}
