using SuperCustomerPlace.Repository.Repository;
using SuperMarketPlace.Model;

namespace SuperMarketPlace.Business.Services
{
    public class CustomerService
    {
        private CustomerRepository repository;

        public CustomerService()
        {
            repository = new CustomerRepository();
        }

        public bool Login(Customer customer)
        {
            return repository.Login(customer);
        }

        public Customer Me()
        {
            return repository.Get(1);
        }
    }
}