using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
        //İş Kodları //Bir iş sınıfı başka sınıfları newlemez.
        //Yetkisi Var mı ? herşey tamamsa aşağıda verilere izin var.
           return _productDal.GetAll();

        }
    }
}
