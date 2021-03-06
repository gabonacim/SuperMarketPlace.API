﻿using SuperMarketPlace.Model;

namespace SuperMarketPlace.Repository.DAL
{
    public interface IOrderDal
    {
        void AddOrder(Order order);

        Order GetProcessedOrder(long idOrder);

        void UpdateOrderStatus(long idOrder, OrderStatusEnum status);
    }
}