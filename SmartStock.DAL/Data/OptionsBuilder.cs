using Microsoft.EntityFrameworkCore;

namespace SmartStock.DAL.Data
{
    public class OptionsBuilder
    {
        public OptionsBuilder()
        {
            _configuration = new ApplicationConfiguration();
            DbContextOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            DbContextOptionsBuilder.UseSqlServer(_configuration.SqlConnectionString);
            DbContextOptions = DbContextOptionsBuilder.Options;
        }

        public DbContextOptionsBuilder<ApplicationContext> DbContextOptionsBuilder { get; set; }

        public DbContextOptions<ApplicationContext> DbContextOptions { get; set; }

        private ApplicationConfiguration _configuration { get; set; }
    }
}