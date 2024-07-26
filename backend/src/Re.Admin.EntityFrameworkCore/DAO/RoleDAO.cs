﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dapper;
using Re.Admin.Database.DAO;
using Re.Admin.EntityFrameworkCore;
using Re.Admin.Models;

using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;

namespace Re.Admin.DAO
{
    public class RoleDAO : DapperRepository<AdminDbContext>, IRoleDAO
    {
        public RoleDAO(IDbContextProvider<AdminDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<List<AppOption>> GetRoleOptionsAsync()
        {
            var conn = await GetDbConnectionAsync();
            return conn.Query<AppOption>("select convert(id,char) as Value,role_name as label from sys_role where is_deleted=0 and role_name != @name",new {name = AdminConsts.SUPERADMIN}).ToList();
        }
    }
}