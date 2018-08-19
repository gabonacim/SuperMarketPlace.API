using SuperMarketPlace.Repository.Model;
using SuperTPlace.Repository.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SuperMarketPlace.Repository.DAL
{
    public class MarketDal : ICrudDal<Market>
    {
        private List<Market> marketList;

        public MarketDal()
        {
            marketList = new List<Market>();

            marketList.Add(new Market()
            {
                Id = 1,
                Name = "Mercado da Esquina",
                CompanyName = "Mercado da Esquina Corporate S.A",
                Document = "15.622.029/0001-82",
                AdressZipCode = "12345678",
                AdressName = "Rua da Esquina",
                AdressNumber = "123",
                AdressComplement = "Perto da esquina",
                AdressNeighborhood = "Bairro",
                AdressCity = "Cidade da Esquina",
                AdressState = "Estado"
            });

            marketList.Add(new Market()
            {
                Id = 2,
                Name = "Movile Hack SuperMarket",
                CompanyName = "Movile Hack SuperMarket S.A",
                Document = "00.731.738/0001-29",
                AdressZipCode = "12345678",
                AdressName = "Rua da Esquina",
                AdressNumber = "123",
                AdressNeighborhood = "Bairro",
                AdressCity = "Cidade da Esquina",
                AdressState = "Estado"
            });

            marketList.Add(new Market()
            {
                Id = 3,
                Name = "Carrefour Bairro",
                CompanyName = "Carrefour Bairro Corporate S.A",
                Document = "50.674.000/0001-45",
                AdressZipCode = "12345678",
                AdressName = "Rua da Esquina",
                AdressNumber = "123",
                AdressNeighborhood = "Bairro",
                AdressCity = "Cidade da Esquina",
                AdressState = "Estado"
            });

            marketList.Add(new Market()
            {
                Id = 4,
                Name = "Mercado do Xerox",
                CompanyName = "Mercado do Xerox S.A.",
                Document = "75.880.998/0001-65",
                AdressZipCode = "12345678",
                AdressName = "Rua da Esquina",
                AdressNumber = "123",
                AdressNeighborhood = "Bairro",
                AdressCity = "Cidade da Esquina",
                AdressState = "Estado"
            });
        }

        public void Add(Market entity)
        {
            marketList.Add(entity);
        }

        public void Delete(long id)
        {
            marketList.Remove(Get(id));
        }

        public Market Get(long id)
        {
            return marketList.FirstOrDefault(f => f.Id == id);
        }

        public List<Market> GetAll()
        {
            return marketList;
        }

        public void Update(Market entity)
        {
            var oldEntity = Get(entity.Id);

            oldEntity = entity;
        }
    }
}