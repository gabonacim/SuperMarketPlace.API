namespace SuperMarketPlace.Model
{
    public class OrderPayment
    {
        public long IdOrder { get; set; }

        public Address Address { get; set; }

        public string CartType { get; set; }

        public string CardNumber { get; set; }

        public string CustomerAddress { get; set; }

        public string CVV { get; set; }

        public string ExpirationDate { get; set; }
    }
}