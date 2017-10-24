using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS.AccountServices
{
    public class LoginService : BaseService, ILoginService
    {
        public LoginService(IUnityManagerModule unityManager) : base(unityManager)
        {
            this.UserRepository = this.UnityManager.Resolve<IUserRepository>();
        }

        public IUserRepository UserRepository { get; set; }

        public bool ValidateUser(string email, string password)
        {
            User user = this.UserRepository.FindUserByEmailAndPassword(email, password);
            if (user == null)
            {
                return false;
            }

            return true;
        }
    }
}