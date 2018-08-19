namespace SuperMarketPlace.Repository.Model
{
    public class CartItem
    {
        public long IdProduct { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}