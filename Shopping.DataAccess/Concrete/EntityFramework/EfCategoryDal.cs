using Shopping.DataAccess.Abstarct;
using Shopping.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,ShoppingContext>,ICategoryDal
    {
        public DbSet<Product> products { get; set;}
        public DbSet<Category> Categories { get; set; }
    }
}
