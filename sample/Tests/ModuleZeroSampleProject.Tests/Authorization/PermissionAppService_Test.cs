using Abp.Authorization.Roles;
using Abp.Domain.Repositories;
using ModuleZeroSampleProject.Authorization;
using ModuleZeroSampleProject.Authorization.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleZeroSampleProject.Users;
using Shouldly;
using Xunit;

namespace ModuleZeroSampleProject.Tests.Authorization
{
    public class PermissionAppService_Test : SampleProjectTestBase
    {
        private readonly IPermissionAppService _permissionAppService;

        private readonly UserManager _userManager;

        public PermissionAppService_Test()
        {
            _permissionAppService = LocalIocManager.Resolve<IPermissionAppService>();
            _userManager = LocalIocManager.Resolve<UserManager>();
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

        [Fact]
        public async Task Should_Grant_User_Permission()
        {
            await _permissionAppService.GrantUser(new GrantUserInput() {PermissionName = "CanCreateQuestions", UserId = 4});

            //Assert.True(await _userManager.IsGrantedAsync(4, "CanCreateQuestions"));

            this.UsingDbContext(context =>
            {
                var permissions = context.UserPermissions.Where(p => p.UserId == 4);

                permissions.ShouldNotBe(null);

                permissions.Count().ShouldBe(2);

                permissions.FirstOrDefault(p => p.Name == "CanCreateQuestions").UserId.ShouldBe(1);
            });
        }
    }
}
