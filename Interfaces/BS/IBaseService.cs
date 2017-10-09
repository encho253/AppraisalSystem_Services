using Interfaces.Repository;

namespace Interfaces.BS
{
    public interface IBaseService
    {
        IUnityManagerModule UnityManager { get; set; }
    }
}