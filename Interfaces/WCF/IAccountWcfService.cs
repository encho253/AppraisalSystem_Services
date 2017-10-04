using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface IAccountWcfService
    {
        [OperationContract]
        bool ValidateUser(string email, string password);
    }
}