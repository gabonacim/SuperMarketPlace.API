using System.Collections.Generic;

namespace SuperMarketPlace.Model
{
    public class Order
    {
        public long IdOrder { get; set; }

        public OrderStatusEnum Status { get; set; }

        public List<OrderProduct> ProductList { get; set; }
    }
}