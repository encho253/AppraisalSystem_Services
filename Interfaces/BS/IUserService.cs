using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IUserService : IBaseService
    {
        IEnumerable<User> GetAllUsers();
        User SearchByFirstName();
        string[] GetRolesForUser(string userName);
    }
}