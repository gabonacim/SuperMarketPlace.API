using SuperCustomerPlace.Repository.DAL;
using SuperMarketPlace.Model;
using SuperTPlace.Repository.DAL;
using System.Collections.Generic;

namespace SuperCustomerPlace.Repository.Repository
{
    public class CustomerRepository
    {
        ICrudDal<Customer> accessDal;

        public CustomerRepository()
        {
            accessDal = new MockCustomerDal();
        }

        public void Add(Customer entity)
        {
            accessDal.Add(entity);
        }

        public Customer Get(long id)
        {
            return accessDal.Get(id);
        }

        public List<Customer> GetAll()
        {
            return accessDal.GetAll();
        }

        public void Delete(long id)
        {
            accessDal.Delete(id);
        }

        public void Update(Customer entity)
        {
            accessDal.Update(entity);
        }

        public bool Login(Customer entity)
        {
            return true;
        }
    }
}