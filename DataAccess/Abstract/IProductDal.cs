using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        //Product Entities referansı kullanıyor.
        List<Product> GetAll();
        void add(Product product);
        void delete(Product product);
        void update(Product product);

        List<Product>GetAllByCategory(int categoryId);  
    }
}
