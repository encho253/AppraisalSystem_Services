using Microsoft.Practices.Unity;
using System;

namespace BS.Configs
{
    public class UnityManagerModule
    {
        public UnityManagerModule()
        {
            this.Container = new UnityContainer();
        }

        public IUnityContainer Container { get; private set; }

        public void Init()
        {

        }

        public T Resolve<T>()
        {
            return this.Container.Resolve<T>();
        }

        public void RegisterInstance<T>(T instance)
        {
            this.Container.RegisterInstance<T>(instance);
        }
    }
}