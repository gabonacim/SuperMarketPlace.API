using System.Collections.Generic;

namespace SuperMarketPlace.Repository.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T Get(long id);

        void Add(T entity);

        void Update(T entity);

        void Delete(long id);
    }
}