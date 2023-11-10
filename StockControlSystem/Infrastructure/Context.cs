using Microsoft.EntityFrameworkCore;
using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Item>()
                .HasOne(item => item.Supplier)
                .WithMany(supplier => supplier.Itens)
                .HasForeignKey(item => item.Id);

            builder.Entity<Item>()
                .HasOne(item => item.Brand)
                .WithMany(brand => brand.Itens)
                .HasForeignKey(item => item.Id);

            builder.Entity<Item>()
                .HasOne(item => item.Category)
                .WithMany(category => category.Itens)
                .HasForeignKey(item => item.Id);

            builder.Entity<Item>().Property(p => p.Price).HasColumnType("decimal(10,2)").HasPrecision(2);

            builder.Entity<Supplier>()
                .HasMany(supplier => supplier.Addresses)
                .WithOne(address => address.Supplier)
                .HasForeignKey(supplier => supplier.Id);

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
