using BS.Configs;
using Interfaces.BS;
using Interfaces.WCF;

namespace WCF
{
    public class AccountService : IAccountService
    {
        public bool ValidateUser(string email, string password)
        {
            using (UnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                ILoginService customerLoginService = dataContainer.Resolve<ILoginService>();
                return customerLoginService.ValidateUser(email, password);
            }
        }
    }
}