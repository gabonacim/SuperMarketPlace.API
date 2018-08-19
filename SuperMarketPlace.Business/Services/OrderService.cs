using SuperMarketPlace.Model;
using SuperOrderPlace.Repository.Repository;

namespace SuperMarketPlace.Business.Services
{
    public class OrderService
    {
        private OrderRepository repository;

        public OrderService()
        {
            repository = new OrderRepository();
        }

        public Order ProcessOrder()
        {
            var order = repository.AddOrder();

            //CartController cart = new CartController();

            //cart.Get();

            //TODO: Send to SNS (who triggers AWS LAMBDA)

            return order;
        }

        public Order GetProcessed(long id)
        {
            return repository.GetProcessed(id);
        }
    }
}
