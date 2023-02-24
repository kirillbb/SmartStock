using Microsoft.EntityFrameworkCore;

namespace SmartStock.DAL.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        //DbSets

        public static OptionsBuilder OptionsBuilder => new OptionsBuilder();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                ApplicationConfiguration configuration = new ApplicationConfiguration();
                optionsBuilder.UseSqlServer(configuration.SqlConnectionString);
            }
        }
    }
}