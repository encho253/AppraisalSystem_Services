﻿using BS.Configs;
using Interfaces.BS;
using Interfaces.WCF;

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

        public void CreateUser(int id, string firstName, string lastName, string password, string email, int roleId)
        {
            using (IUnityManagerModule dataContainer = new UnityManagerModule())
            {
                dataContainer.Init();
                IRegisterService customerRegisterService = dataContainer.Resolve<IRegisterService>();
                customerRegisterService.CreateUser(id, firstName, lastName, password, email, roleId);
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