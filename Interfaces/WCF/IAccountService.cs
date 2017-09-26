using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        void DoWork();
    }
}