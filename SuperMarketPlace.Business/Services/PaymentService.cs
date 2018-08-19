using SuperMarketPlace.Model;
using SuperOrderPlace.Repository.Repository;

namespace SuperMarketPlace.Business.Services
{
    public class PaymentService
    {
        private OrderRepository orderRepository;

        public PaymentService()
        {
            orderRepository = new OrderRepository();
        }

        public void PayOrder(OrderPayment orderPayment)
        {
            //TODO: Send to SNS (who will process payment)

            //TODO: Send notification to customer (E-mail/SMS)

            orderRepository.UpdateOrderStatus(orderPayment.IdOrder, OrderStatusEnum.WAITING_PAYMENT);
        }
    }
}
