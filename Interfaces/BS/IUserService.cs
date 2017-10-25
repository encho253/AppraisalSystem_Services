using DB;
using Interfaces.Repository;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IUserService : IBaseService
    {
        IUserRepository UserRepository { get; }

        IEnumerable<User> GetAllUsers();
        User SearchByUserName(string userName);
        string[] GetRolesForUser(string userName);
    }
}