namespace SuperMarketPlace.Repository.Model
{
    public class Product
    {
        public long Id { get; set; }

        public long IdMarket { get; set; }

        public ProductType Type { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? StockQuantity { get; set; }
    }
}