using SuperMarketPlace.Business.Services;
using SuperMarketPlace.Model;
using System.Net;
using System.Web.Http;

namespace SuperCustomerPlace.API.Controllers
{
    public class CustomerController : ApiController
    {
        private CustomerService service;

        public CustomerController()
        {
            service = new CustomerService();
        }

        [HttpPost]
        [Route("api/customer/login")]
        public void Login([FromBody]Customer customer)
        {
            if (service.Login(customer) == false)
            {
                throw new HttpResponseException(HttpStatusCode.Forbidden);
            }
        }

        [HttpGet]
        [Route("api/customer/me")]
        public Customer Me()
        {
            var customer = service.Me();

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return customer;
        }
    }
}