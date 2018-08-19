using SuperMarketPlace.Business.Services;
using SuperMarketPlace.Model;
using System.Net;
using System.Web.Http;

namespace SuperCustomerPlace.API.Controllers
{
    public class PaymentController : ApiController
    {
        PaymentService paymentService;

        public PaymentController()
        {
            paymentService = new PaymentService();
        }

        [HttpPost]
        [Route("api/payment/payorder")]
        public void PayOrder([FromBody]OrderPayment orderPayment)
        {
            paymentService.PayOrder(orderPayment);
        }
    }
}