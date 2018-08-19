using SuperMarketPlace.Business.Services;
using SuperMarketPlace.Model;
using System.Net;
using System.Web.Http;

namespace SuperCustomerPlace.API.Controllers
{
    public class OrderController : ApiController
    {
        OrderService orderService;

        public OrderController()
        {
            orderService = new OrderService();
        }

        [HttpPost]
        [Route("api/order/process")]
        public Order Process([FromBody]Cart cart)
        {
            return orderService.ProcessOrder();
        }

        [HttpGet]
        [Route("api/order/getprocessed/{id}")]
        public Order GetProcessed(long id)
        {
            if (id <= 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return orderService.GetProcessed(id);
        }
    }
}