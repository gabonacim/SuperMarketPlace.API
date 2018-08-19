using SuperMarketPlace.Repository.Model;
using SuperMarketPlace.Repository.Repository;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace SuperMarketPlace.API.Controllers
{
    public class ProductController : ApiController
    {
        private ProductRepository repository;

        public ProductController()
        {
            repository = new ProductRepository();
        }

        public IEnumerable<Product> Get()
        {
            return repository.GetAll();
        }

        public Product Get(long id)
        {
            var product = repository.Get(id);

            if (product == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return product;
        }

        public void Post([FromBody]Product value)
        {
            if (value == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            repository.Add(value);
        }

        public void Put(int id, [FromBody]Product value)
        {
            if (id <= 0 || value == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Update(value);
        }

        public void Delete(long id)
        {
            if (id <= 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Delete(id);
        }
    }
}