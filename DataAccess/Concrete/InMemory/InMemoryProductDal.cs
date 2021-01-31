using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{Id=1, BrandId=4, ColorId=9, ModelYear=2013, DailyPrice=231, Description="Orta seviye arzulayanların arabası."},
                new Product{Id=2, BrandId=4, ColorId=1, ModelYear=2015, DailyPrice=255, Description="Orta seviye arzulayanların arabası."},
                new Product{Id=3, BrandId=4, ColorId=1, ModelYear=2015, DailyPrice=250, Description="Orta seviye arzulayanların arabası."},
                new Product{Id=4, BrandId=9, ColorId=1, ModelYear=2015, DailyPrice=280, Description="Orta seviye arzulayanların arabası."},
                new Product{Id=5, BrandId=9, ColorId=9, ModelYear=2010, DailyPrice=150, Description="Ekonomik, güvenilir."},
                new Product{Id=6, BrandId=9, ColorId=5, ModelYear=2019, DailyPrice=335, Description="Hem lüx, hem ekonomik."},
                new Product{Id=7, BrandId=1, ColorId=5, ModelYear=2019, DailyPrice=350, Description="Hem lüx, hem ekonomik."},
                new Product{Id=8, BrandId=1, ColorId=4, ModelYear=2019, DailyPrice=350, Description="Hem lüx, hem ekonomik."},
                new Product{Id=9, BrandId=2, ColorId=2, ModelYear=2019, DailyPrice=350, Description="Hem lüx, hem ekonomik."},
                new Product{Id=10, BrandId=3, ColorId=3, ModelYear=2020, DailyPrice=450, Description="Lüxün daha makulu."},
                new Product{Id=11, BrandId=4, ColorId=3, ModelYear=2020, DailyPrice=500, Description="Lüxü arzulayanlar için."},

            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }
        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int Id)
        {
            return _products.Where(p => p.Id == Id).ToList();
        }

    }
}
