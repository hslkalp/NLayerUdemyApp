using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Sait Faik",
                    Price = 54.2m,
                    Stock = 15,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Name = "Ekonomi",
                    Price = 31.2m,
                    Stock = 25,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Name = "Siyasal Bilimler",
                    Price = 65.2m,
                    Stock = 7,
                    CreatedDate = DateTime.Now,
                }
                );
        }
    }
}
