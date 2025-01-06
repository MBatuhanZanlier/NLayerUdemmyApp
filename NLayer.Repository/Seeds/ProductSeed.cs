using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds;

public class ProductSeed : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(
            new Product { Id = 1, Name = "Kalemler1", CategoryId = 1, Price = 100, Stock = 20, CreatedDate = DateTime.Now },
            new Product { Id = 2, Name = "Kitap", CategoryId = 2, Price = 300, Stock = 120, CreatedDate = DateTime.Now },
           new Product { Id = 3, Name = "Kitap2", CategoryId = 3, Price = 200, Stock = 50, CreatedDate = DateTime.Now });
    }
}
