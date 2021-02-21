using Shopping.Business.Abstarct;
using Shopping.DataAccess.Abstarct;
using Shopping.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {  
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
