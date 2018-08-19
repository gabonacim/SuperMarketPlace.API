namespace SuperMarketPlace.Model
{
    public class Market : Adress
    {
        public long Id { get; set; }

        public string Document { get; set; }

        public string Name { get; set; }

        public string CompanyName { get; set; }
    }
}
