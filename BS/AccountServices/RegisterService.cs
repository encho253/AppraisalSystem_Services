using DB;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS.AccountServices
{
    public class RegisterService : IRegisterService
    {
        private IUnitOfWork unitOfWork;

        public RegisterService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void CreateUser(string firstName, string lastName, string password, string email, int roleId)
        {
            this.unitOfWork.AccountRepository.AddUser(firstName, lastName, password, email, roleId);
        }
    }
}