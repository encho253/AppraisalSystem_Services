using DB;
using System.Data.Entity.Core.Metadata.Edm;

namespace Repository
{
    public class UnitOfWork
    {
        AppraisalDbContext dbContext = new AppraisalDbContext();

        public GenericRepository<TEntityType> GetRepoInstance<TEntityType>() where TEntityType : class
        {
            return new GenericRepository<TEntityType>(this.dbContext);
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }
    }
}