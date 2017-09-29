using DB;
using System;


namespace Repository
{
    public class UnitOfWork : IDisposable
    {
        private AppraisalDbContext dbContext = null;
        AccountRepository<User> accountRepository = null;

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

        public AccountRepository<User> AccountRepository
        {
            get
            {
                if (this.accountRepository == null)
                {
                    this.accountRepository = new AccountRepository<User>(this.DbContext);
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