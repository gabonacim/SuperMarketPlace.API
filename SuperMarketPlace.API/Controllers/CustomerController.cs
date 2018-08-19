using SuperCustomerPlace.Repository.Repository;
using SuperMarketPlace.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        //public IEnumerable<Customer> Get()
        //{
        //    return repository.GetAll();
        //}

        //public Customer Get(long id)
        //{
        //    var customer = repository.Get(id);

        //    if (customer == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    return customer;
        //}

        //public void Post([FromBody]Customer value)
        //{
        //    if (value == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);
        //    }

        //    repository.Add(value);
        //}

        //public void Put(int id, [FromBody]Customer value)
        //{
        //    if (id <= 0 || value == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }

        //    repository.Update(value);
        //}

        //public void Delete(long id)
        //{
        //    if (id <= 0)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }

        //    repository.Delete(id);
        //}

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
