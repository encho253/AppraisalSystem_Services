using System;

namespace Interfaces.BS
{
    public interface IUnityManagerModule : IDisposable
    {
        void Init();
        T Resolve<T>();
        void RegisterInstance<T>(T instance);
    }
}