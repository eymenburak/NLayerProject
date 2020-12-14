using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seeds
{
    class ProductSeed :IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Pencil", Price = 12.50m, Stock = 100, CategoryId = _ids[0] },
                new Product { Id = 2, Name = "Pen", Price = 40.50m, Stock = 200, CategoryId = _ids[0] },
                new Product { Id = 3, Name = "Book", Price = 500m, Stock = 250, CategoryId = _ids[0] },
                new Product { Id = 4, Name = "Ruler", Price = 500m, Stock = 250, CategoryId = _ids[1] },
                new Product { Id = 5, Name = "Desk", Price = 500m, Stock = 100, CategoryId = _ids[1] },
                new Product { Id = 6, Name = "Erase", Price = 500m, Stock = 50, CategoryId = _ids[1] }
                );
        }
    }
}
