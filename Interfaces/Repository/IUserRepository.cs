using DB;

namespace Interfaces.Repository
{
    public interface IUserRepository : IGenericRepository<User> 
    {
        User FindUserByEmailAndPassword(string email, string password);
    }
}