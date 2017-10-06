using System.ServiceModel;

namespace Interfaces.WCF
{
    [ServiceContract]
    public interface IAccountWcfService
    {
        [OperationContract]
        bool ValidateUser(string email, string password);

        [OperationContract]
        void CreateUser(int id, string firstName, string lastName, string password, string email, int roleId);

        [OperationContract]
        string[] GetRolesForUser(string userName);
    }
}