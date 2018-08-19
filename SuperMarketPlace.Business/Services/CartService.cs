using SuperCartPlace.Repository.Repository;
using SuperMarketPlace.Model;

namespace SuperMarketPlace.Business.Services
{
    public class CartService
    {
        private CartRepository repository;

        public CartService()
        {
            repository = new CartRepository();
        }

        public Cart Get()
        {
            return repository.Get();
        }

        public void Add(CartItem cartitem)
        {
            repository.Add(cartitem);
        }

        public void Delete(long id)
        {
            repository.Delete(id);
        }
    }
}