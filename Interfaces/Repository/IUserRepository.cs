using DB;

namespace Interfaces.Repository
{
    public interface IUserRepository
    {
        User FindUserByEmailAndPassword(string email, string password);
        void AddUser(int id, string firstName, string lastname, string password, string email, int roleId);
    }
}