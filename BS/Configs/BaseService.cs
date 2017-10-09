using Interfaces.BS;

namespace BS.Configs
{
    public abstract class BaseService : IBaseService
    {
        public BaseService(IUnityManagerModule unityManager)
        {
            this.UnityManager = unityManager;
        }

        public IUnityManagerModule UnityManager { get; set; }
    }
}