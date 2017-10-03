using DB;
using Interfaces.Repository;
using System;


namespace Repository
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private AppraisalDbContext dbContext = null;
        IUserRepository userRepository = null;
        IEvaluationTemplateRepository evaluationTemplateRepository = null;

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

        public IUserRepository UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new UserRepository(this.DbContext);
                }

                return this.userRepository;
            }
        }

        public IEvaluationTemplateRepository EvaluationTemplateRepository
        {
            get
            {
                if (this.evaluationTemplateRepository == null)
                {
                    this.evaluationTemplateRepository = new EvaluationTemplateRepository(this.DbContext);
                }

                return this.evaluationTemplateRepository;
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