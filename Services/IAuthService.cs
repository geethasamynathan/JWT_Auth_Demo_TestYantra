namespace JWT_Auth_Demo.Services
{
    public interface IAuthService
    {
        string Authenticate(string username, string password);
    }
}
