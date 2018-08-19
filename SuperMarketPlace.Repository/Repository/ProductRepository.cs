using SuperMarketPlace.Model;
using SuperProductPlace.Repository.DAL;
using SuperTPlace.Repository.DAL;
using System.Collections.Generic;

namespace SuperMarketPlace.Repository.Repository
{
    public class ProductRepository
    {
        ICrudDal<Product> accessDal;

        public ProductRepository()
        {
            accessDal = new MockProductDal();
        }

        public void Add(Product entity)
        {
            accessDal.Add(entity);
        }

        public Product Get(long id)
        {
            return accessDal.Get(id);
        }

        public List<Product> GetAll()
        {
            return accessDal.GetAll();
        }

        public void Delete(long id)
        {
            accessDal.Delete(id);
        }

        public void Update(Product entity)
        {
            accessDal.Update(entity);
        }
    }
}