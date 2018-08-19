using SuperCustomerPlace.Repository.Repository;
using SuperMarketPlace.Repository.Model;
using System.Net;
using System.Web.Http;

namespace SuperCustomerPlace.API.Controllers
{
    public class CustomerController : ApiController
    {
        private CustomerRepository repository;

        public CustomerController()
        {
            repository = new CustomerRepository();
        }

        [HttpPost]
        [Route("api/customer/login")]
        public void Login([FromBody]Customer customer)
        {
            if (repository.Login(customer) == false)
            {
                throw new HttpResponseException(HttpStatusCode.Forbidden);
            }
        }

        [HttpGet]
        [Route("api/customer/me")]
        public Customer Me()
        {
            var customer = repository.Get(1);

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return customer;
        }
    }
}
