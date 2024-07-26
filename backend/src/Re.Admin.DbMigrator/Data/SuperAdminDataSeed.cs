using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using Re.Admin.Entity;
using Re.Admin.Helpers;

using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Re.Admin.Data
{
    public class SuperAdminDataSeed : IDataSeedContributor, ITransientDependency
    {
        private readonly IConfiguration _configuration;
        private readonly IRepository<SysRole> _roleRepository;
        private readonly IRepository<SysUser> _userRepository;
        private readonly IRepository<SysUserRole> _userRoleRepository;
        private readonly ILogger<SuperAdminDataSeed> _logger;

        public SuperAdminDataSeed(IConfiguration configuration, IRepository<SysRole> roleRepository
            , IRepository<SysUser> userRepository, IRepository<SysUserRole> userRoleRepository, ILogger<SuperAdminDataSeed> logger)
        {
            _configuration = configuration;
            _roleRepository = roleRepository;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _logger = logger;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            var enabled = Convert.ToBoolean(_configuration["App:EnabledSeedData"]);
            if (!enabled) return;
            _logger.LogInformation("超级管理员种子数据开始...");
            var role = (await _roleRepository.GetQueryableAsync()).Where(x => x.RoleName == AdminConsts.SUPERADMIN).FirstOrDefault();
            if (role == null)
            {
                role = new SysRole
                {
                    RoleName = AdminConsts.SUPERADMIN,
                    Remark = "系统默认创建，拥有所有权限"
                };
                role = await _roleRepository.InsertAsync(role, true);
            }
            var user = (await _userRepository.GetQueryableAsync()).Where(x => x.UserName == AdminConsts.SUPER_USER).FirstOrDefault();
            if (user == null)
            {
                user = new SysUser
                {
                    UserName = AdminConsts.SUPER_USER,
                    NickName = AdminConsts.SUPER_USER,
                    PasswordSalt = EncryptionHelper.GetPasswordSalt(),
                    IsEnabled = true,
                    Avatar = "images/boy.png",
                    Sex = 1
                };
                user.Password = EncryptionHelper.GenEncodingPassword(AdminConsts.SUPER_USER_PWD, user.PasswordSalt);
                user = await _userRepository.InsertAsync(user, true);
            }
            var userRole = await _userRoleRepository.SingleOrDefaultAsync(x => x.UserId == user.Id && x.RoleId == role.Id);
            if (userRole == null)
            {
                userRole = new SysUserRole
                {
                    UserId = user.Id,
                    RoleId = role.Id
                };
                await _userRoleRepository.InsertAsync(userRole, true);
            }
            _logger.LogInformation("超级管理员种子数据结束.");
        }
    }
}