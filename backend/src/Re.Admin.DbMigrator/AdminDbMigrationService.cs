using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Re.Admin.DbMigrator
{
    public class AdminDbMigrationService : ITransientDependency
    {
        private readonly IDataSeeder _dataSeeder;

        public AdminDbMigrationService(IDataSeeder dataSeeder)
        {
            _dataSeeder = dataSeeder;
        }

        public async Task MigrateAsync()
        {
            await _dataSeeder.SeedAsync();
        }
    }
}