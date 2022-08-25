using Microsoft.EntityFrameworkCore;
using PizzaHouseApp.Models.Entities;

namespace PizzaHouseApp.Dal.EfStructures
{
    public class PizzaHouseAppDbContext : DbContext
    {
        public PizzaHouseAppDbContext(DbContextOptions<PizzaHouseAppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Pizza>? Pizzas { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderMenu>? OrderMenus { get; set; }
        public DbSet<Payment>? Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(c => c.FullName)
                    .HasColumnName(nameof(Customer.FullName))
                    .HasComputedColumnSql("[LastName] + ', ' + [FirstName]");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
