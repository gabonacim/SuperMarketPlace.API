using SuperMarketPlace.Repository.DAL;
using SuperMarketPlace.Repository.Model;
using System.Collections.Generic;
using System.Linq;

namespace SuperCartPlace.Repository.Repository
{
    public class CartRepository
    {
        MockDal accessDal;

        public CartRepository()
        {
            accessDal = new MockDal();
        }

        public void Add(CartItem entity)
        {
            var cart = accessDal.GetCarts();

            if (cart == null)
            {
                cart = new List<Cart>();
            }

            cart.First().Items.Add(entity);
        }

        public Cart Get()
        {
            return accessDal.GetCarts().FirstOrDefault();
        }

        public void Delete(long idProduct)
        {
            var cart = Get();

            var cartItem = cart.Items.Where(i => i.IdProduct == idProduct).FirstOrDefault();

            cart.Items.Remove(cartItem);
        }
    }
}