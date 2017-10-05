namespace Interfaces.BS
{
    public interface IRegisterService : IBaseService
    {
        void CreateUser(int id, string firstName, string lastName, string password, string email, int roleId);
    }
}