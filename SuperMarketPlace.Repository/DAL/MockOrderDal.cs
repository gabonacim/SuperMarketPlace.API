using SuperMarketPlace.Repository.Model;
using System;
using System.Collections.Generic;

namespace SuperMarketPlace.Repository.DAL
{
    public class MockOrderDal : IOrderDal
    {
        private List<Order> OrderList;

        public void AddOrder(Order order)
        {
            OrderList = new List<Order>();

            order.IdOrder = 1;

            OrderList.Add(order);
        }

        public Order GetProcessedOrder(long idOrder)
        {
            Random random = new Random();

            var order = new Order();

            order.IdOrder = idOrder;
            order.Status = OrderStatusEnum.PENDING;

            if (random.Next(0, 10) % 2 == 0)
            {
                order.Status = OrderStatusEnum.PROCESSED;

                order.ProductList = new List<OrderProduct>();

                var orderProduct = new OrderProduct();

                orderProduct.Product = new Product()
                {
                    Id = 1,
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
                };

                orderProduct.Market = new Market()
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
                };

                order.ProductList.Add(orderProduct);

                var orderProduct2 = new OrderProduct();

                orderProduct2.Product = new Product()
                {
                    Id = 4,
                    IdMarket = 2,
                    Type = new ProductType()
                    {
                        Id = 1000,
                        Name = "Saco de lixo - 100 L - Marca X",
                        BarCode = "1312321123"
                    },
                    Name = "Saco de lixo 100 L",
                    Price = 5
                };

                orderProduct2.Market = new Market()
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
                };

                order.ProductList.Add(orderProduct2);
            }

            return order;
        }
    }
}