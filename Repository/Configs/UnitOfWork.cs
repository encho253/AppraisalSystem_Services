using DB;
using Interfaces.Repository;
using System;


namespace Repository.Configs
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private AppraisalDbContext dbContext = null;
        IUserRepository userRepository = null;
        IEvaluationTemplateRepository evaluationTemplateRepository = null;
        IPositionRepository positionRepository = null;
        ICompetenceRepository competenceRepository = null;
        IQuestionRepository questionRepository = null;
        IEvaluationRepository evaluationRepository = null;
        IResultRepository resultRepository = null;

        private bool disposed = false;

        private AppraisalDbContext DbContext
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

        public IPositionRepository PositionRepository
        {
            get
            {
                if (this.positionRepository == null)
                {
                    this.positionRepository = new PositionRepository(this.DbContext);
                }
                return this.positionRepository;
            }       
        }

        public ICompetenceRepository CompetenceRepository
        {
            get
            {
                if (this.competenceRepository == null)
                {
                    this.competenceRepository = new CompetenceRepository(this.DbContext);
                }
                return this.competenceRepository;
            }
        }

        public IQuestionRepository QuestionRepository
        {
            get
            {
                if (this.questionRepository == null)
                {
                    this.questionRepository = new QuestionRepository(this.DbContext);
                }
                return this.questionRepository;
            }
        }

        public IEvaluationRepository EvaluationRepository
        {
            get
            {
                if (this.evaluationRepository == null)
                {
                    this.evaluationRepository = new EvaluationRepository(this.DbContext);
                }
                return this.evaluationRepository;
            }
        }

        public IResultRepository ResultRepository
        {
            get
            {
                if (this.resultRepository == null)
                {
                    this.resultRepository = new ResultRepository(this.DbContext);
                }
                return this.resultRepository;
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