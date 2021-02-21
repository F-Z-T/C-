using Shopping.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Business.Abstarct
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        
    }
}
