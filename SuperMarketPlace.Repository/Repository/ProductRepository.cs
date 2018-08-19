using SuperMarketPlace.Repository.DAL;
using SuperMarketPlace.Repository.Model;
using System.Collections.Generic;
using System.Linq;

namespace SuperMarketPlace.Repository.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        MockDal accessDal;

        public ProductRepository()
        {
            accessDal = new MockDal();
        }

        public void Add(Product entity)
        {
            accessDal.GetProducts().Add(entity);
        }

        public Product Get(long id)
        {
            return accessDal.GetProducts().FirstOrDefault(ml => ml.Id == id);
        }

        public List<Product> GetAll()
        {
            return accessDal.GetProducts();
        }

        public void Delete(long id)
        {
            var Product = Get(id);

            accessDal.GetProducts().Remove(Product);
        }

        public void Update(Product entity)
        {
            var Product = Get(entity.Id);

            Product = entity;
        }
    }
}