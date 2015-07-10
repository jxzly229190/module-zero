using Abp.Application.Services;
using Abp.Authorization.Roles;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleZeroSampleProject.Authorization.Dto;
using ModuleZeroSampleProject.MultiTenancy;
using ModuleZeroSampleProject.Users;
using Abp.Authorization;

namespace ModuleZeroSampleProject.Authorization
{
    public interface IPermissionAppService : IApplicationService
    {
        void GrantRole(GrantRoleInput input);

        void GrantUser(GrantUserInput input);
    }

    public class PermissionAppService : IPermissionAppService, IApplicationService
    {

        //private readonly IRolePermissionStore<Tenant, Role, User> _rolePermissionStore;

        private readonly IRepository<Role,int> _roleRepository;

        private readonly IRepository<RolePermissionSetting,long> PermissionSetting;
        public PermissionAppService(IRepository<RolePermissionSetting, long> permissionSetting, IRepository<Role, int> roleRepository)
        {
            //this._rolePermissionStore = rolePermissionStore;
            this._roleRepository = roleRepository;

            this.PermissionSetting = permissionSetting;
        }

        public void GrantRole(GrantRoleInput input)
        {
            var role = _roleRepository.Get(input.RoleId);

            if (role == null)
            {
                throw new Exception("role is not found.");
            }

            this.PermissionSetting.InsertOrUpdate(new RolePermissionSetting() { IsGranted = true, RoleId = input.RoleId, Name = input.PermissionName });

            //_rolePermissionStore.AddPermissionAsync(role, new PermissionGrantInfo(input.PermissionName, true));
        }

        public void GrantUser(GrantUserInput input)
        {
            throw new NotImplementedException();
        }
    }
}
