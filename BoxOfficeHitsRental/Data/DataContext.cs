using BoxOfficeHitsRentalCore.Entities;
using BoxOfficeHitsRentalCore.Entities.Products;
using BoxOfficeHitsRentalCore.Entities.Relational;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BoxOfficeHitsRental.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            SeedDefaultProducts();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerProduct> CustomerProducts { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureEntityPrimaryKeys(modelBuilder);
            ConfigureEntityProperties(modelBuilder);
            ConfigureEntityRelationships(modelBuilder);
        }

        private void SeedDefaultProducts()
        {
            if (!Products.Any())
            {
                Products.Add(new Product()
                {
                   Title = "Default Film",
                   Type = "Film",
                   Price = 12.00M
                });
                SaveChanges();
            }

            if (!Products.Any())
            {
                Products.Add(new Product()
                {
                    Title = "Default Film Box Set",
                    Type = "Film Box Set",
                    Price = 49.95M
                });
                SaveChanges();
            }

            if (!Products.Any())
            {
                Products.Add(new Product()
                {
                    Title = "Default TV Series Box Set",
                    Type = "TV Series Box Set",
                    Price = 67.99M
                });
                SaveChanges();
            }

            if (!Customers.Any())
            {
                Customers.Add(new Customer()
                {
                    Forename = "Jane",
                    Surname = "Doe",
                    AccountBalance = 100.00M,
                });
                SaveChanges();
            }
        }

        private static void ConfigureEntityPrimaryKeys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<CustomerProduct>()
                .HasKey(cp => new{cp.CustomerId, cp.ProductId});
        }

        private static void ConfigureEntityProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(c => c.Forename)
                .IsRequired()
                .HasMaxLength(51);

            modelBuilder.Entity<Customer>()
                .Property(c => c.Surname)
                .IsRequired()
                .HasMaxLength(51);

            modelBuilder.Entity<Customer>()
                .Property(c => c.AccountBalance)
                .IsRequired()
                .HasPrecision(9, 2);


            modelBuilder.Entity<Product>()
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(51);

            modelBuilder.Entity<Product>()
                .Property(p => p.Genre)
                .IsRequired()
                .HasMaxLength(51);

            modelBuilder.Entity<Product>()
                .Property(p => p.Type)
                .IsRequired()
                //.HasConversion<string>()
                .HasMaxLength(51);

            modelBuilder.Entity<Product>()
                .Property(p => p.Rating)
                .IsRequired()
                .HasMaxLength(51);
                
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .IsRequired()
                .HasPrecision(9, 2);
        }

        private static void ConfigureEntityRelationships(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalogue>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Catalogue)
                .HasForeignKey(p => p.CatalogueId);

            modelBuilder.Entity<CustomerProduct>()
                .HasOne(c => c.Product)
                .WithMany(p => p.Customers)
                .HasForeignKey(c => c.ProductId);

            modelBuilder.Entity<CustomerProduct>()
                .HasOne(p => p.Customer)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CustomerId);
        }
    }
}
