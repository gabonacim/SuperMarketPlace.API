using SuperMarketPlace.Repository.Model;
using System.Collections.Generic;

namespace SuperMarketPlace.Repository.DAL
{
    public class MockDal
    {
        private List<Market> MarketList;

        public MockDal()
        {
            MarketList = new List<Market>();

            MarketList.Add(new Market()
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

            MarketList.Add(new Market()
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

            MarketList.Add(new Market()
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

            MarketList.Add(new Market()
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

        public List<Market> GetMarkets()
        {
            return MarketList;
        }
    }
}