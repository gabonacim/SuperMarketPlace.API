using SuperMarketPlace.Model;
using SuperMarketPlace.Repository.Repository;
using System.Collections.Generic;

namespace SuperMarketPlace.Business.Services
{
    public class MarketService
    {
        private MarketRepository repository;

        public MarketService()
        {
            repository = new MarketRepository();
        }

        public IEnumerable<Market> GetAll()
        {
            return repository.GetAll();
        }

        public Market Get(long id)
        {
            return repository.Get(id);
        }

        public void Add(Market value)
        {
            repository.Add(value);
        }

        public void Update(Market value)
        {
            repository.Update(value);
        }

        public void Delete(long id)
        {
            repository.Delete(id);
        }
    }
}