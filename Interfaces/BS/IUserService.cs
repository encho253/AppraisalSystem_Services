using DB;
using System.Collections.Generic;

namespace Interfaces.BS
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User SearchByFirstName();
    }
}