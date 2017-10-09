using System;
using DB;
using Interfaces.BS;
using BS.Configs;
using Interfaces.Repository;

namespace BS.AccountServices
{
    public class RegisterService : BaseService, IRegisterService
    {
        public RegisterService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.UserRepository = this.UnityManager.Resolve<IUserRepository>();
        }

        public IUserRepository UserRepository { get; set; }

        public void CreateUser(int id, string firstName, string lastName, string password, string email, int roleId)
        {
            this.UserRepository.Add(new User { Id = id, FirstName = firstName, LastName = lastName, Password = password, Email = email, RoleId = roleId });
        }
    }
}