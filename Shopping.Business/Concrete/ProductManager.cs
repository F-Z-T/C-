using Shopping.Business.Abstarct;
using Shopping.DataAccess.Abstarct;
using Shopping.DataAccess.Concrete;
using Shopping.DataAccess.Concrete.EntityFramework;
using Shopping.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Shopping.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager
            (IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
             return _productDal.GetAll();
        }

     
        public List<Product> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch(DbUpdateException e)
            {
                throw new Exception("Ürün Silme İşlemi Gerçekleşemedi.");
            }
            
        }
    }
}
