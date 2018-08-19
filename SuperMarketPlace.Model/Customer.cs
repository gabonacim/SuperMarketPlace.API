namespace SuperMarketPlace.Model
{
    public class Customer : Address
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}