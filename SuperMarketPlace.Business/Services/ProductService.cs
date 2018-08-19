using SuperMarketPlace.Model;
using SuperMarketPlace.Repository.Repository;
using System.Collections.Generic;

namespace SuperMarketPlace.Business.Services
{
    public class ProductService
    {
        private ProductRepository repository;

        public ProductService()
        {
            repository = new ProductRepository();
        }

        public IEnumerable<Product> GetAll()
        {
            return repository.GetAll();
        }

        public Product Get(long id)
        {
            return repository.Get(id);
        }

        public void Add(Product value)
        {
            repository.Add(value);
        }

        public void Update(Product value)
        {
            repository.Update(value);
        }

        public void Delete(long id)
        {
            repository.Delete(id);
        }
    }
}