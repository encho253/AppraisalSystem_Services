using BS.Configs;
using Interfaces.BS;
using Interfaces.WCF;
using Repository.Configs;

namespace WCF
{
    public class AccountService : IAccountWcfService
    {
        public bool ValidateUser(string email, string password)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                ILoginService customerLoginService = dataContainer.Resolve<ILoginService>();
                return customerLoginService.ValidateUser(email, password);
            }
        }

        public void CreateUser(string firstName, string lastName, string password, string email)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IRegisterService customerRegisterService = dataContainer.Resolve<IRegisterService>();
                customerRegisterService.CreateUser(firstName, lastName, password, email);

                var unity = new UnitOfWork();

                unity.SaveChanges();
            }
        }

        public string[] GetRolesForUser(string userName)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IUserService customerUserService = dataContainer.Resolve<IUserService>();
                string[] roles = customerUserService.GetRolesForUser(userName);

                return roles;
            }
        }
    }
}