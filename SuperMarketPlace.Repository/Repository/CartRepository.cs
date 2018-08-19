using SuperMarketPlace.Repository.DAL;
using SuperMarketPlace.Repository.Model;

namespace SuperCartPlace.Repository.Repository
{
    public class CartRepository
    {
        ICartDal accessDal;

        public CartRepository()
        {
            accessDal = new MockCartDal();
        }

        public void Add(CartItem entity)
        {
            var cart = accessDal.Get();

            if (cart == null)
            {
                cart = new Cart();
            }

            cart.Items.Add(entity);
        }

        public Cart Get()
        {
            return accessDal.Get();
        }

        public void Delete(long idProduct)
        {
            accessDal.Delete(idProduct);
        }
    }
}