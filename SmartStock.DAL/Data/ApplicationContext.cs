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

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderProduct> OrderProducts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserOrder> UserOrders { get; set; }

        public static OptionsBuilder OptionsBuilder => new OptionsBuilder();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>()
            .HasKey(op => new { op.OrderId, op.ProductId });

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderProducts)
                .HasForeignKey(op => op.OrderId);

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(op => op.ProductId);

            modelBuilder.Entity<UserOrder>()
                .HasOne(uo => uo.User)
                .WithMany(u => u.UserOrders)
                .HasForeignKey(uo => uo.UserId);

            modelBuilder.Entity<UserOrder>()
                .HasOne(x => x.Order)
                .WithOne(u => u.UserOrder)
                .HasForeignKey<UserOrder>(x => x.OrderId);
        }

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