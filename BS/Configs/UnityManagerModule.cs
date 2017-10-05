using BS.AccountServices;
using Interfaces.BS;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Repository;
using System;

namespace BS.Configs
{
    public class UnityManagerModule : IDisposable
    {
        private IUnityContainer container;
        private bool disposed = false;

        public UnityManagerModule()
        {
            this.container = new UnityContainer();
        }


        public void Init()
        {
            this.container.RegisterType<IUnitOfWork, UnitOfWork>();
            this.container.RegisterType<IBaseService, BaseService>(new InjectionConstructor(this.container.Resolve<IUnitOfWork>()));

            this.container.RegisterType<IUserRepository, UserRepository>();
            this.container.RegisterType<ILoginService, LoginService>();
            this.container.RegisterType<IRegisterService, RegisterService>();

            this.container.RegisterType<IPositionRepository, PositionRepository>();
            this.container.RegisterType<IPositionService, PositionService>();

            this.container.RegisterType<IEvaluationTemplateRepository, EvaluationTemplateRepository>();
            this.container.RegisterType<IEvaluationTemplateService, EvaluationTemplateService>();
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