using SuperMarketPlace.Repository.Model;
using SuperMarketPlace.Repository.Repository;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace SuperMarketPlace.API.Controllers
{
    public class MarketController : ApiController
    {
        private MarketRepository repository;

        public MarketController()
        {
            repository = new MarketRepository();
        }

        public IEnumerable<Market> Get()
        {
            return repository.GetAll();
        }

        public Market Get(long id)
        {
            var market = repository.Get(id);

            if (market == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return market;
        }

        public void Post([FromBody]Market value)
        {
            if (value == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            repository.Add(value);
        }

        public void Put(int id, [FromBody]Market value)
        {
            if (id <= 0 || value == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Update(value);
        }

        public void Delete(long id)
        {
            if (id <= 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Delete(id);
        }
    }
}