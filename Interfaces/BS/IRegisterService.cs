namespace Interfaces.BS
{
    public interface IRegisterService : IBaseService
    {
        void CreateUser(string firstName, string lastName, string password, string email);
    }
}