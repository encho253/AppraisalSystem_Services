using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS.AccountServices
{
    public class LoginService : ILoginService
    {
        private IUnitOfWork unitOfWork;

        public LoginService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool ValidateUser(string email, string password)
        {
            User user = this.unitOfWork.AccountRepository.FindUser(email, password);
            if (user == null)
            {
                return false;
            }

            return true;
        }
    }
}