using DB;

namespace Interfaces.Repository
{
    public interface IUserRepository : IGenericRepository<User> 
    {
        User FindUserByEmailAndPassword(string email, string password);
        User FindUserByName(string userName);
        string[] GetRolesForUser(string userName);
    }
}