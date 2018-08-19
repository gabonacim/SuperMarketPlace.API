using SuperMarketPlace.Business.Services;
using SuperMarketPlace.Model;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace SuperMarketPlace.API.Controllers
{
    public class MarketController : ApiController
    {
        private MarketService service;

        public MarketController()
        {
            service = new MarketService();
        }

        public IEnumerable<Market> Get()
        {
            return service.GetAll();
        }

        public Market Get(long id)
        {
            var market = service.Get(id);

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

            service.Add(value);
        }

        public void Put(int id, [FromBody]Market value)
        {
            if (id <= 0 || value == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            service.Update(value);
        }

        public void Delete(long id)
        {
            if (id <= 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            service.Delete(id);
        }
    }
}