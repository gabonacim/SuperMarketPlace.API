using SuperMarketPlace.Business.Services;
using SuperMarketPlace.Model;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace SuperMarketPlace.API.Controllers
{
    public class ProductController : ApiController
    {
        private ProductService Service;

        public ProductController()
        {
            Service = new ProductService();
        }

        public IEnumerable<Product> Get()
        {
            return Service.GetAll();
        }

        public Product Get(long id)
        {
            var product = Service.Get(id);

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

            Service.Add(value);
        }

        public void Put(int id, [FromBody]Product value)
        {
            if (id <= 0 || value == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Service.Update(value);
        }

        public void Delete(long id)
        {
            if (id <= 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Service.Delete(id);
        }
    }
}