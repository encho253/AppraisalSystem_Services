using BS.Configs;
using DB;
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
            this.UnitOfWork.UserRepository.Add(new User { Id = id, FirstName = firstName, LastName = lastName, Password = password, Email = email, RoleId = roleId });
        }

        public void SaveChanges()
        {
            this.UnitOfWork.SaveChanges();
        }
    }
}