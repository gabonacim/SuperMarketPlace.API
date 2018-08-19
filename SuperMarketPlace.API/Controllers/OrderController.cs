using SuperMarketPlace.Repository.Model;
using SuperOrderPlace.Repository.Repository;
using System.Net;
using System.Web.Http;

namespace SuperCustomerPlace.API.Controllers
{
    public class OrderController : ApiController
    {
        private OrderRepository repository;

        public OrderController()
        {
            repository = new OrderRepository();
        }

        [HttpPost]
        [Route("api/order/process")]
        public Order Process([FromBody]Cart cart)
        {
            var order = repository.AddOrder();

            //CartController cart = new CartController();

            //cart.Get();

            //TODO: Send to SNS (who triggers AWS LAMBDA)

            return order;
        }

        [HttpGet]
        [Route("api/order/getprocessed/{id}")]
        public Order GetProcessed(long id)
        {
            if (id <= 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return repository.GetProcessed(id);
        }
    }
}