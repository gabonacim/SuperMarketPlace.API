using SuperCartPlace.Repository.Repository;
using SuperMarketPlace.Repository.Model;
using System.Net;
using System.Web.Http;

namespace SuperCustomerPlace.API.Controllers
{
    public class CartController : ApiController
    {
        private CartRepository repository;

        public CartController()
        {
            repository = new CartRepository();
        }

        public Cart Get()
        {
            return repository.Get();
        }

        public void Post([FromBody]CartItem value)
        {
            if (value == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            repository.Add(value);
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
