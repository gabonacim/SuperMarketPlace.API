using SuperMarketPlace.Model;
using SuperTPlace.Repository.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SuperCustomerPlace.Repository.DAL
{
    public class MockCustomerDal : ICrudDal<Customer>
    {
        private List<Customer> customerList;

        public MockCustomerDal()
        {
            customerList = new List<Customer>();

            customerList.Add(new Customer()
            {
                Id = 1,
                Name = "Maria Aparecida",
                Email = "maria.aparecida@smarket.com",
                Password = "********",
                AdressZipCode = "031130-030",
                AdressName = "Avenida Piaui",
                AdressNumber = "95",
                AdressComplement = "Perto do Mercado",
                AdressNeighborhood = "Vila Clementino",
                AdressCity = "São Paulo",
                AdressState = "SP"
            });

            customerList.Add(new Customer()
            {
                Id = 1,
                Name = "Cliente",
                Email = "cliente@cliente.com",
                Password = "********",
                AdressZipCode = "12345678",
                AdressName = "Rua da Esquina",
                AdressNumber = "123",
                AdressComplement = "Perto da esquina",
                AdressNeighborhood = "Bairro",
                AdressCity = "Cidade da Esquina",
                AdressState = "Estado"
            });
        }

        public void Add(Customer entity)
        {
            customerList.Add(entity);
        }

        public void Delete(long id)
        {
            customerList.Remove(Get(id));
        }

        public Customer Get(long id)
        {
            return customerList.FirstOrDefault(f => f.Id == id);
        }

        public List<Customer> GetAll()
        {
            return customerList;
        }

        public void Update(Customer entity)
        {
            var oldEntity = Get(entity.Id);

            oldEntity = entity;
        }
    }
}