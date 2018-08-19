using SuperMarketPlace.Model;
using System.Collections.Generic;
using System.Linq;

namespace SuperMarketPlace.Repository.DAL
{
    public class MockCartDal : ICartDal
    {
        Cart cart;

        public MockCartDal()
        {
            cart = new Cart()
            {
                Total = 10
            };
            
            var cartItemList = new List<CartItem>();

            cartItemList.Add(new CartItem()
            {
                IdProduct = 1,
                Name = "Sabão em pó",
                Price = 15,
                Quantity = 1
            });

            cartItemList.Add(new CartItem()
            {
                IdProduct = 15,
                Name = "Saco de lixo",
                Price = 9,
                Quantity = 1
            });

            cartItemList.Add(new CartItem()
            {
                IdProduct = 500,
                Name = "Refrigerante 2 L",
                Price = 8,
                Quantity = 1
            });

            cart.Items = new List<CartItem>();

            cart.Items.AddRange(cartItemList);
        }

        public void Add(CartItem entity)
        {
            cart.Items.Add(entity);
        }

        public Cart Get()
        {
            return cart;
        }

        public void Delete(long idProduct)
        {
            var cart = Get();

            var cartItem = cart.Items.Where(i => i.IdProduct == idProduct).FirstOrDefault();

            cart.Items.Remove(cartItem);
        }
    }
}