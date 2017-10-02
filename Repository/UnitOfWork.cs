using DB;
using Interfaces.Repository;
using System;


namespace Repository
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private AppraisalDbContext dbContext = null;
        IAccountRepository accountRepository = null;

        private bool disposed = false;

        public AppraisalDbContext DbContext
        {
            get
            {
                if (this.dbContext == null)
                {
                    this.dbContext = new AppraisalDbContext();
                }

                return this.dbContext;
            }
        }

        public IAccountRepository AccountRepository
        {
            get
            {
                if (this.accountRepository == null)
                {
                    this.accountRepository = new AccountRepository(this.DbContext);
                }

                return this.accountRepository;
            }
        }


        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
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