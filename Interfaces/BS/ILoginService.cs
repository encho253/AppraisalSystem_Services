namespace Interfaces.BS
{
    public interface ILoginService
    {
        bool ValidateUser(string email, string password);
    }
}