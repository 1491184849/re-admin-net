using System.Threading.Tasks;
using Re.Admin.Entity;

using Volo.Abp.DependencyInjection;

namespace Re.Admin.Database.DAO
{
    public interface ILoginLogDAO : ITransientDependency
    {
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> WriteAsync(SysLoginLog entity);
    }
}