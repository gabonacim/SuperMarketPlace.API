using SuperMarketPlace.Repository.DAL;
using SuperMarketPlace.Repository.Model;

namespace SuperOrderPlace.Repository.Repository
{
    public class OrderRepository
    {
        IOrderDal accessDal;

        public OrderRepository()
        {
            accessDal = new MockOrderDal();
        }

        public Order AddOrder()
        {
            var newOrder = new Order()
            {
                Status = OrderStatusEnum.PENDING
            };

            accessDal.AddOrder(newOrder);

            return newOrder;
        }

        public Order GetProcessed(long idOrder)
        {
            var order = accessDal.GetProcessedOrder(idOrder);

            return order;
        }
    }
}