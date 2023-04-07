using ClothingAppAPI.Enums;
using ClothingAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

namespace ClothingAppAPI.DAL
{
    public class ClothingContext:DbContext
    {
        public DbSet<Product> ProductCategories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get;set; }
        public ClothingContext(DbContextOptions<ClothingContext> o) : base(o)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Description).IsRequired();
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
                entity.Property(e => e.Gender).HasConversion(new EnumToStringConverter<GenderTypeEnum>());
                entity.Property(e => e.Status).HasConversion(new EnumToStringConverter<ProductStatus>());
                entity.Property(e => e.Size).HasConversion(new EnumToStringConverter<Size>());
                entity.HasOne(e => e.ProductCategory)
                    .WithMany(e => e.Products)
                    .HasForeignKey(e => e.CategoryId)
                    .IsRequired();
                entity.HasMany(e => e.Reviews)
                    .WithOne(e => e.Product)
                    .HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.Cascade);
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.UpdatedAt).IsRequired();
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.HasMany(e => e.Products)
                    .WithOne(e => e.ProductCategory)
                    .HasForeignKey(e => e.CategoryId)
                    .IsRequired();
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.UpdatedAt).IsRequired();
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.Product)
                    .WithMany()
                    .HasForeignKey(e => e.ProductId)
                    .IsRequired();
                entity.Property(e => e.TotalCost).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.UpdatedAt).IsRequired();
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Content).IsRequired();
                entity.Property(e => e.Rating).IsRequired();
                entity.HasOne(e => e.Product)
                    .WithMany(e => e.Reviews)
                    .HasForeignKey(e => e.ProductId).IsRequired(false);
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.UpdatedAt).IsRequired();
            });

            modelBuilder.Entity<ProductCategory>().HasData(
                    new ProductCategory
                    {
                        Id = 1,
                        Name = "Tops",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new ProductCategory
                    {
                        Id = 2,
                        Name = "Bottoms",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Long Sleeve Short",
                        Description = "Very Beatiful Long Sleeve made of wool",
                        Price = 90,
                        Quantity = 10,
                        Size = Enums.Size.M,
                        Gender = Enums.GenderTypeEnum.MALE,
                        Status = Enums.ProductStatus.AVAILABLE,
                        CategoryId = 1,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Jeans",
                        Description = "Very Beatiful Long Sleeve made of wool",
                        Price = 100,
                        Quantity = 10,
                        Size = Enums.Size.M,
                        Gender = Enums.GenderTypeEnum.MALE,
                        Status = Enums.ProductStatus.AVAILABLE,
                        CategoryId = 1,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    }
                );
            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    Id = 1,
                    Content = "Afsafaf",
                    Rating = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    ProductId = 2
                }
                );
        }
    }
}
