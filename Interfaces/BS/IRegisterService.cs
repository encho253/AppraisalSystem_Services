namespace Interfaces.BS
{
    public interface IRegisterService
    {
        void CreateUser(string firstName, string lastName, string password, string email, int roleId);
    }
}