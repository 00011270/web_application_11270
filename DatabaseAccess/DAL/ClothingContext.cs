using ClothingAppAPI.Enums;
using ClothingAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingAppAPI.DAL
{
    public class ClothingContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Product> ProductCategories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
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
                    .HasForeignKey(e => e.ProductId);
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
                entity.HasOne(e => e.User)
                    .WithMany(u => u.OrderDetails)
                    .HasForeignKey(e => e.UserId)
                    .IsRequired();
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
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.Content).IsRequired();
                entity.Property(e => e.Rating).IsRequired();
                entity.HasOne(e => e.Product)
                    .WithMany(e => e.Reviews)
                    .HasForeignKey(e => e.ProductId)
                    .IsRequired();
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.UpdatedAt).IsRequired();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.Phone).IsRequired();
                entity.Property(e => e.Status).HasConversion(new EnumToStringConverter<UserStatus>()).IsRequired();
                entity.Property(e => e.Role).HasConversion(new EnumToStringConverter<UserRole>()).IsRequired();
                entity.Property(e => e.CreatedAt).IsRequired();
                entity.Property(e => e.UpdatedAt).IsRequired();
                entity.HasOne(e => e.Card)
                      .WithOne(c => c.User)
                      .HasForeignKey<Card>(c=>c.UserId);
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Number).IsRequired();
                entity.Property(e => e.Balance).IsRequired();
                entity.Property(e => e.ExpirationDate).IsRequired();
                entity.Property(e => e.Status).IsRequired().HasConversion(new EnumToStringConverter<CardStatus>());
                entity.Property(e => e.CreatedAt).IsRequired();
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
        }
    }
}
