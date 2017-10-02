using DB;

namespace Interfaces.Repository
{
    public interface IAccountRepository
    {
        User FindUser(string email, string password);
        void AddUser(string firstName, string lastname, string password, string email, int roleId);
    }
}