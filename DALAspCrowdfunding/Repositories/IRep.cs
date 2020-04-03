using System.Collections.Generic;

namespace DALAspCrowdfunding.Repositories
{
    public interface IRep<TKey, T> where T : class
    {
        IEnumerable<T> Get();
        T Get(TKey id);
        void Add(T entity);
        void Update(TKey id, T entity);
        void Delete(TKey id);
    }
}
