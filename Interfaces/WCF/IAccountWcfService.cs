using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface IAccountWcfService
    {
        [OperationContract]
        bool ValidateUser(string email, string password);

        [OperationContract]
        void CreateUser(string firstName, string lastName, string password, string email);

        [OperationContract]
        string[] GetRolesForUser(string userName);
    }
}