using Shopping.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess.Abstarct
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
