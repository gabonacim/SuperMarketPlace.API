using SuperMarketPlace.Repository.DAL;
using SuperMarketPlace.Repository.Model;
using SuperTPlace.Repository.DAL;
using System.Collections.Generic;

namespace SuperMarketPlace.Repository.Repository
{
    public class MarketRepository
    {
        ICrudDal<Market> accessDal;

        public MarketRepository()
        {
            accessDal = new MarketDal();
        }

        public void Add(Market entity)
        {
            accessDal.Add(entity);
        }

        public Market Get(long id)
        {
            return accessDal.Get(id);
        }

        public List<Market> GetAll()
        {
            return accessDal.GetAll();
        }

        public void Delete(long id)
        {
            accessDal.Delete(id);
        }

        public void Update(Market entity)
        {
            accessDal.Update(entity);
        }
    }
}