using System.Collections.Generic;

namespace Interfaces.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllRecords();

        TEntity GetFirstOrDefault(int recordId);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void SaveChanges();
    }
}