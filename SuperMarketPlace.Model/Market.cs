namespace SuperMarketPlace.Model
{
    public class Market : Address
    {
        public long Id { get; set; }

        public string Document { get; set; }

        public string Name { get; set; }

        public string CompanyName { get; set; }
    }
}
