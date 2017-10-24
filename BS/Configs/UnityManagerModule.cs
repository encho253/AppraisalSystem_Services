using BS.AccountServices;
using Interfaces.BS;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Repository;
using Repository.Configs;
using System;

namespace BS.Configs
{
    public class UnityManagerModule : IDisposable, IUnityManagerModule
    {
        private IUnityContainer container;
        private IUnitOfWork unitOfWork = null;
        private bool disposed = false;

        public UnityManagerModule()
        {
            this.container = new UnityContainer();
        }

        private IUnitOfWork UnitOfWork
        {
            get
            {
                return this.unitOfWork;
            }
            set
            {
                this.unitOfWork = value;
            }
        }

        public void Init()
        {
            this.container.RegisterType<IUnitOfWork, UnitOfWork>();
            this.UnitOfWork = this.container.Resolve<IUnitOfWork>();

            this.container.RegisterType<IBaseService, BaseService>(new InjectionConstructor(this));

            this.container.RegisterType<IUserRepository, UserRepository>();
            this.container.RegisterType<ILoginService, LoginService>(new InjectionConstructor(this));
            this.container.RegisterType<IRegisterService, RegisterService>(new InjectionConstructor(this));
            this.container.RegisterType<IUserService, UserService>(new InjectionConstructor(this));

            this.container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>), new InjectionConstructor(this.UnitOfWork));

            this.container.RegisterType<IPositionRepository, PositionRepository>();
            this.container.RegisterType<IPositionService, PositionService>(new InjectionConstructor(this));

            this.container.RegisterType<IEvaluationTemplateRepository, EvaluationTemplateRepository>();
            this.container.RegisterType<IEvaluationTemplateService, EvaluationTemplateService>(new InjectionConstructor(this));

            this.container.RegisterType<ICompetenceRepository, CompetenceRepository>();
            this.container.RegisterType<ICompetenceService, CompetenceService>(new InjectionConstructor(this));

            this.container.RegisterType<IQuestionRepository, QuestionRepository>();
            this.container.RegisterType<IQuestionService, QuestionService>(new InjectionConstructor(this));

            this.container.RegisterType<IEvaluationRepository, EvaluationRepository>();
            this.container.RegisterType<IEvaluationService, EvaluationService>(new InjectionConstructor(this));
        }

        public T Resolve<T>()
        {
            return this.container.Resolve<T>();
        }

        public void RegisterInstance<T>(T instance)
        {
            this.container.RegisterInstance<T>(instance);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                this.container.Dispose();
            }

            disposed = true;
        }
    }
}