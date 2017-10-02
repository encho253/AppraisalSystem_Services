using BS.Configs;
using Interfaces.BS;
using Repository;

namespace BS.AccountServices
{
    public class LoginServices : BaseService, Ilogin
    {
        public LoginServices(UnityManagerModule container) : base(container)
        {
        }

        public bool ValidateUser(string email, string password)
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            var user = unitOfWork.AccountRepository.FindUser(email, password);

            if (user == null)
            {
                return false;
            }

            //var p = repo.GetFirstOrDefault();

            return true;
        }
    }
}