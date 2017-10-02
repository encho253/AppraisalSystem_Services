namespace Interfaces.BS
{
    public interface IRegisterService
    {
        void CreateUser(int id, string firstName, string lastName, string password, string email, int roleId);
        void SaveChanges();
    }
}