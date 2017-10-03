﻿using BS.Configs;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS.AccountServices
{
    public class RegisterService : BaseService, IBaseService, IRegisterService
    {
        public RegisterService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void CreateUser(int id, string firstName, string lastName, string password, string email, int roleId)
        {
            this.UnitOfWork.UserRepository.AddUser(id, firstName, lastName, password, email, roleId);
        }

        public void SaveChanges()
        {
            this.UnitOfWork.SaveChanges();
        }
    }
}