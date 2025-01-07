using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Reposiories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public Task<Category> GetSingleCategoryByWithProductAsync(int categorId)
        {
            return _appDbContext.Categories.Include(x => x.Products).Where(x => x.Id == categorId).SingleOrDefaultAsync(); //Singileor default o ıd den bir tane var ise onu getirir ama o ıd den birden fazla var ise hata döndürür o yüzden burada single kullanmak daha mantıklı birden fazla aynı id den var ise zaten hata var demektir.
        }
    }
}
