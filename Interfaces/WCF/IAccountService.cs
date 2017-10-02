using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        bool ValidateUser(string email, string password);
    }
}