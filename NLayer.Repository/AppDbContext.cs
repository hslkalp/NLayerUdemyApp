using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<ProductFeature>().HasData(
                new ProductFeature
                {
                    Id = 1,
                    Color = "Yeşil",
                    Height = 150,
                    Width = 78,
                    ProductId = 1
                },
                new ProductFeature
                {
                    Id = 2,
                    Color = "Mor",
                    Height = 21,
                    Width = 8,
                    ProductId = 2
                },
                new ProductFeature
                {
                    Id = 3,
                    Color = "Mor",
                    Height = 11,
                    Width = 7,
                    ProductId = 3
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
