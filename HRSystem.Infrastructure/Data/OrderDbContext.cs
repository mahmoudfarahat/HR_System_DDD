using HRSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.Infrastructure.Data
{
    public class OrderDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Items)
                .WithOne()
                .HasForeignKey("OrderId");

            modelBuilder.Entity<OrderItem>()
                .Property(i => i.Price)
                .HasConversion(
                    money => money.Value,
                    value => Money.FromDecimal(value)
                );
        }
    }
}
