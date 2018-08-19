using SuperMarketPlace.Repository.DAL;
using SuperMarketPlace.Repository.Model;
using SuperMarketPlace.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperCustomerPlace.Repository.Repository
{
    public class CustomerRepository
    {
        MockDal accessDal;

        public CustomerRepository()
        {
            accessDal = new MockDal();
        }

        public void Add(Customer entity)
        {
            accessDal.GetCustomers().Add(entity);
        }

        public Customer Get(long id)
        {
            return accessDal.GetCustomers().FirstOrDefault(ml => ml.Id == id);
        }

        public List<Customer> GetAll()
        {
            return accessDal.GetCustomers();
        }

        public void Delete(long id)
        {
            var Customer = Get(id);

            accessDal.GetCustomers().Remove(Customer);
        }

        public void Update(Customer entity)
        {
            var Customer = Get(entity.Id);

            Customer = entity;
        }

        public bool Login(Customer entity)
        {
            return true;
        }
    }
}