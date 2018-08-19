using SuperMarketPlace.Model;
using SuperTPlace.Repository.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SuperProductPlace.Repository.DAL
{
    public class MockProductDal : ICrudDal<Product>
    {
        private List<Product> productList;

        public MockProductDal()
        {
            productList = new List<Product>();

            productList.Add(new Product()
            {
                Id = 1,
                IdMarket = 1,
                Type = new ProductType()
                {
                    Id = 1000,
                    Name = "Sabão em Pó OMO - 1 KG",
                    BarCode = "27891150008506"
                },
                Name = "OMO 1 KG",
                Price = 10,
                StockQuantity = 100
            });

            productList.Add(new Product()
            {
                Id = 2,
                IdMarket = 2,
                Type = new ProductType()
                {
                    Id = 1000,
                    Name = "Sabão em Pó OMO - 1 KG",
                    BarCode = "27891150008506"
                },
                Name = "OMO - Sabão 1 KG",
                Price = 11,
                StockQuantity = 50
            });

            productList.Add(new Product()
            {
                Id = 3,
                IdMarket = 3,
                Type = new ProductType()
                {
                    Id = 1000,
                    Name = "Sabão em Pó OMO - 1 KG",
                    BarCode = "27891150008506"
                },
                Name = "OMO - Sabão 1 KG",
                Price = 9,
                StockQuantity = 1000
            });

            productList.Add(new Product()
            {
                Id = 4,
                IdMarket = 3,
                Type = new ProductType()
                {
                    Id = 1000,
                    Name = "Saco de lixo - 100 L - Marca X",
                    BarCode = "1312321123"
                },
                Name = "Saco de lixo 100 L",
                Price = 5
            });

            productList.Add(new Product()
            {
                Id = 5,
                IdMarket = 2,
                Type = new ProductType()
                {
                    Id = 1000,
                    Name = "Saco de lixo - 100 L - Marca X",
                    BarCode = "1312321123"
                },
                Name = "Saco de lixo 100 L",
                Price = 8
            });

            productList.Add(new Product()
            {
                Id = 6,
                IdMarket = 1,
                Type = new ProductType()
                {
                    Id = 1000,
                    Name = "Saco de lixo - 100 L - Marca X",
                    BarCode = "1312321123"
                },
                Name = "Saco de lixo 100 L",
                Price = 9
            });
        }

        public void Add(Product entity)
        {
            productList.Add(entity);
        }

        public void Delete(long id)
        {
            productList.Remove(Get(id));
        }

        public Product Get(long id)
        {
            return productList.FirstOrDefault(f => f.Id == id);
        }

        public List<Product> GetAll()
        {
            return productList;
        }

        public void Update(Product entity)
        {
            var oldEntity = Get(entity.Id);

            oldEntity = entity;
        }
    }
}