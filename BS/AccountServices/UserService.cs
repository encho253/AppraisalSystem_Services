using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace BS.AccountServices
{
    public class UserService : BaseService, IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUnityManagerModule unityManager) : base(unityManager)
        {
            userRepository = this.UnityManager.Resolve<IUserRepository>();
        }

        public IUserRepository UserRepository
        {
            get
            {
                return this.userRepository;
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public string[] GetRolesForUser(string userName)
        {
            return this.userRepository.GetRolesForUser(userName);
        }

        public User SearchByFirstName()
        {
            throw new NotImplementedException();
        }
    }
}