using DB;
using Interfaces.BS;
using BS.Configs;
using Interfaces.Repository;
using System;

namespace BS.AccountServices
{
    public class RegisterService : BaseService, IRegisterService
    {
        public RegisterService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.UserRepository = this.UnityManager.Resolve<IUserRepository>();
        }

        public IUserRepository UserRepository { get; set; }

        public void CreateUser(string firstName, string lastName, string password, string email)
        {
            var random = new Random();
            int id = random.Next(0, 10000);

            int roleId = random.Next(1, 3);

            this.UserRepository.Add(new User
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Password = password,
                Email = email,
                RoleId = roleId
            });
        }
    }
}