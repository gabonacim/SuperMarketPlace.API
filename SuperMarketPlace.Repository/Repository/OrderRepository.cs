using SuperMarketPlace.Repository.DAL;
using SuperMarketPlace.Model;
using System;

namespace SuperOrderPlace.Repository.Repository
{
    public class OrderRepository
    {
        IOrderDal accessDal;

        public OrderRepository()
        {
            accessDal = new MockOrderDal();
        }

        public object UpdateOrder { get; set; }

        public Order AddOrder()
        {
            var newOrder = new Order()
            {
                Status = OrderStatusEnum.PENDING
            };

            accessDal.AddOrder(newOrder);

            return newOrder;
        }

        public void UpdateOrderStatus(long idOrder, OrderStatusEnum status)
        {
            accessDal.UpdateOrderStatus(idOrder, status);
        }

        public Order GetProcessed(long idOrder)
        {
            var order = accessDal.GetProcessedOrder(idOrder);

            return order;
        }
    }
}