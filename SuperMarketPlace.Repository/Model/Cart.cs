using System.Collections.Generic;

namespace SuperMarketPlace.Repository.Model
{
    public class Cart
    {
        public List<CartItem> Items { get; set; }

        public decimal Total { get; set; }
    }
}