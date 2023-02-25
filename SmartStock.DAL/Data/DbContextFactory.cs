using Microsoft.EntityFrameworkCore;

namespace SmartStock.DAL.Data
{
    public class DbContextFactory
    {
        public ApplicationContext CreateDbContext()
        {
            ApplicationConfiguration configuration = new ApplicationConfiguration();
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            dbContextOptionsBuilder.UseSqlServer(configuration.SqlConnectionString);
            return new ApplicationContext(dbContextOptionsBuilder.Options);
        }
    }
}