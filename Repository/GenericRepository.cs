using DB;
using Interfaces.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> dbSet;
        private AppraisalDbContext dbContext;

        public GenericRepository(AppraisalDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAllRecords()
        {
            return this.dbSet.ToList();
        }
    }
}