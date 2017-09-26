namespace BS.Configs
{
    public abstract class BaseService
    {
        public BaseService(UnityManagerModule container)
        {
            this.IocContainer = container;
        }

        public UnityManagerModule IocContainer { get; }
    }
}