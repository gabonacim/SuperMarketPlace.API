using System.Collections.Generic;

namespace SuperTPlace.Repository.DAL
{
    public interface ICrudDal<T>
    {
        void Add(T entity);

        T Get(long id);

        List<T> GetAll();

        void Delete(long id);

        void Update(T entity);
    }
}