using System;
using System.Threading.Tasks;
using Re.Admin.Database.DAO;
using Re.Admin.Entity;
using Re.Admin.EntityFrameworkCore;

namespace Re.Admin.DAO
{
    public class LoginLogDAO : ILoginLogDAO
    {
        private readonly AdminDbContext _context;

        public LoginLogDAO(AdminDbContext context)
        {
            _context = context;
        }

        public async Task<int> WriteAsync(SysLoginLog entity)
        {
            entity.SetCreationTime();
            _context.Add(entity);
            return await _context.SaveChangesAsync();
        }
    }
}