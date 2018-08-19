using SuperMarketPlace.Repository.Model;

namespace SuperMarketPlace.Repository.DAL
{
    public interface ICartDal
    {
        void Add(CartItem entity);

        Cart Get();

        void Delete(long idProduct);
    }
}