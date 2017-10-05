namespace Interfaces.BS
{
    public interface ILoginService : IBaseService
    {
        bool ValidateUser(string email, string password);
    }
}