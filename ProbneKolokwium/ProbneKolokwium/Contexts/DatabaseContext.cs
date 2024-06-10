using Microsoft.EntityFrameworkCore;
using ProbneKolokwium.Models;

namespace ProbneKolokwium.Contexts;

public class DatabaseContext : DbContext
{
    
    public DbSet<Client>Clients { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductOrder> ProductOrders { get; set; }
    public DbSet<Status> Statuses { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>().HasData(
            new Client { ClientId = 1, ClientFirstName = "John", ClientLastName = "Doe" },
            new Client { ClientId = 2, ClientFirstName = "Jane", ClientLastName = "Smith" }
        );

        // Seed data for Statuses
        modelBuilder.Entity<Status>().HasData(
            new Status { StatusId = 1, StatusName = "Pending" },
            new Status { StatusId = 2, StatusName = "Completed" }
        );

        // Seed data for Products
        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, ProductName = "Laptop", ProductPrice = 999.99 },
            new Product { ProductId = 2, ProductName = "Smartphone", ProductPrice = 499.99 }
        );

        // Seed data for Orders
        modelBuilder.Entity<Order>().HasData(
            new Order
            {
                OrderId = 1,
                CreatedAt = new DateTime(2023, 1, 1),
                FullfilledAt = new DateTime(2023, 1, 5),
                ClientId = 1,
                StatusId = 2
            },
            new Order
            {
                OrderId = 2,
                CreatedAt = new DateTime(2023, 2, 1),
                FullfilledAt = null,
                ClientId = 2,
                StatusId = 1
            }
        );

        // Seed data for ProductOrders
        modelBuilder.Entity<ProductOrder>().HasData(
            new ProductOrder { ProductId = 1, OrderId = 1, Amount = 1 },
            new ProductOrder { ProductId = 2, OrderId = 1, Amount = 2 },
            new ProductOrder { ProductId = 1, OrderId = 2, Amount = 1 }
        );
        
    }
}