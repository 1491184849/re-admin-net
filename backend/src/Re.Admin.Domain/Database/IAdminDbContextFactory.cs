using Microsoft.EntityFrameworkCore;

namespace Re.Admin.Database
{
    public interface IAdminDbContextFactory
    {
        DbContext CreateDbContext();
    }
}