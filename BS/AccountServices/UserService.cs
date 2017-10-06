using System;
using System.Collections.Generic;
using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS.AccountServices
{
    public class UserService : BaseService, IBaseService, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public string[] GetRolesForUser(string userName)
        {
            return this.UnitOfWork.UserRepository.GetRolesForUser(userName);
        }

        public User SearchByFirstName()
        {
            throw new NotImplementedException();
        }
    }
}