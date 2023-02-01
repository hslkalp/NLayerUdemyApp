using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NLayer.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            #region Add Data Category
            builder.HasData(
                new Category
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    Name = "Kitaplar",
                },
                new Category
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    Name = "Defter",
                },
                new Category
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    Name = "Kalem",
                }
            );
            #endregion
        }
    }
}
