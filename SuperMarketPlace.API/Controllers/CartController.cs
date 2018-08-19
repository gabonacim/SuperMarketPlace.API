using SuperMarketPlace.Business.Services;
using SuperMarketPlace.Model;
using System.Net;
using System.Web.Http;

namespace SuperCustomerPlace.API.Controllers
{
    public class CartController : ApiController
    {
        private CartService service;

        public CartController()
        {
            service = new CartService();
        }

        public Cart Get()
        {
            return service.Get();
        }

        public void Post([FromBody]CartItem value)
        {
            if (value == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            service.Add(value);
        }

        public void Delete(long id)
        {
            if (id <= 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            service.Delete(id);
        }
    }
}