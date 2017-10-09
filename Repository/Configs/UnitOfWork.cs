using DB;
using Interfaces.Repository;
using System;


namespace Repository.Configs
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private static AppraisalDbContext dbContext = null;
        private bool disposed = false;

        public AppraisalDbContext DbContext
        {
            get
            {
                if (dbContext == null)
                {
                    dbContext = new AppraisalDbContext();
                }

                return dbContext;
            }
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.DbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}