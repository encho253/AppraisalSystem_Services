using DB;

namespace Interfaces.Repository
{
    public interface IAccountRepository
    {
        User FindUser(string email, string password);
    }
}