using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    // Navigation property, bir veri modelinde, iki varlık arasındaki ilişkiyi temsil eden ve bu ilişkiyi sorgulamak veya erişmek için kullanılan özelliklerdir.
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
