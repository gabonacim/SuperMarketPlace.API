using SuperMarketPlace.Repository.DAL;
using SuperMarketPlace.Repository.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SuperMarketPlace.Repository.Repository
{
    public class MarketRepository : IRepository<Market>
    {
        MockDal accessDal;

        public MarketRepository()
        {
            accessDal = new MockDal();
        }

        public void Add(Market entity)
        {
            accessDal.GetMarkets().Add(entity);
        }

        public Market Get(long id)
        {
            return accessDal.GetMarkets().FirstOrDefault(ml => ml.Id == id);
        }

        public List<Market> GetAll()
        {
            return accessDal.GetMarkets();
        }

        public void Delete(long id)
        {
            var market = Get(id);

            accessDal.GetMarkets().Remove(market);
        }

        public void Update(Market entity)
        {
            var market = Get(entity.Id);

            market = entity;
        }
    }
}