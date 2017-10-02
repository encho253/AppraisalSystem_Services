using BS.Configs;
using DB;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS.AccountServices
{
    public class LoginService : BaseService, ILoginService
    {
        public LoginService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public bool ValidateUser(string email, string password)
        {
            User user = this.UnitOfWork.AccountRepository.FindUser(email, password);
            if (user == null)
            {
                return false;
            }

            return true;
        }
    }
}