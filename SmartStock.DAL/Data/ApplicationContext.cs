using Microsoft.EntityFrameworkCore;
using SmartStock.CORE.Entities;
using SmartStock.CORE.Entities.OrderType;
using SmartStock.CORE.Entities.ProductType;

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

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderProduct> OrderProducts { get; set; }

        public virtual DbSet<User> Users { get; set; }

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