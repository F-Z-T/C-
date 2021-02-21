using Shopping.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess.Concrete.EntityFramework
{
    public class ShoppingContext:DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
