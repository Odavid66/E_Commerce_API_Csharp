using Microsoft.EntityFrameworkCore;
using E_commerce_API.Entities;

namespace E_commerce_API.Data
{
    // Inheriting from DbContext is what gives this class its database superpowers
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // Define your DbSets (tables) here
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        

        // You can configure relationships and constraints here if needed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Example: modelBuilder.Entity<User>().HasKey(u => u.Id);
        }
    }
}
