using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemortyProductsDal : IProductDal
    {
        List<Product> _products;
        public InMemortyProductsDal()
        {
            //Oracle,SqlServer,Postgress,MangoDb
            _products = new List<Product> { 
            new Product{ ProductId = 1 , CategoryId=1,ProductName="Bardak ",UnıtPrice=15,UnıtsInStock=15},
                        new Product{ ProductId = 2 , CategoryId=1,ProductName="Kamera ",UnıtPrice=500,UnıtsInStock=3},
            new Product{ ProductId = 3 , CategoryId=1,ProductName="Telefon ",UnıtPrice=1500,UnıtsInStock=2},
                        new Product{ ProductId = 4 , CategoryId=1,ProductName="Klavye ",UnıtPrice=150,UnıtsInStock=65},
            new Product{ ProductId = 5 , CategoryId=1,ProductName="Fare ",UnıtPrice=85,UnıtsInStock=1}



            };

        }
        public void add(Product product)
        {
            _products.Add(product); 
        }
        //Delete özel olarak ıd alınmalıdır. Referans olduğu için.
        public void delete(Product product)
        {
            //LİNQ Liste  bazlı kullanımları sql gibi filtrelenebiliyor.
            // = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId) {

            //    productToDelete= p;
            //    }

            //} //Bizim yerimize ürünleri tek tek dolaşmaya yarar.
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
       _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
                }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void update(Product product)
        { //Gönderdiğim ürün ıd sine sahip olan ürün idsine sahip ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId= product.CategoryId;
            productToUpdate.UnıtPrice = product.UnıtPrice;
            productToUpdate.UnıtsInStock= product.UnıtsInStock;
        }
    }
}
