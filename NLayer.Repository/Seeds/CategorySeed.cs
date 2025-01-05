using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           throw new NotImplementedException();
        }
    }
}
