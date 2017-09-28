using System.Collections.Generic;

namespace Interfaces.Repository
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> GetAllRecords();

        TEntity GetFirstOrDefault(int recordId);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}