using Coravel.Invocable;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Re.Admin.Jobs
{
    public class BusinessJob : IInvocable, ITransientDependency
    {
        public Task Invoke()
        {
            return Task.CompletedTask;
        }
    }
}