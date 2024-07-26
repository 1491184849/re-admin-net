using System.Collections.Generic;
using System.Threading.Tasks;
using Re.Admin.Models;

using Volo.Abp.DependencyInjection;

namespace Re.Admin.Database.DAO
{
    public interface IRoleDAO : ITransientDependency
    {
        Task<List<AppOption>> GetRoleOptionsAsync();
    }
}