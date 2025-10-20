namespace Infrastructure.DataProvider.Servives.DataBaseServices
{
    public interface IAuthenticate
    {
        Task<bool> Has_Authenticate(string email, string password);
        Task<bool> RegisterUser(string email, string password);
        Task LogOut();
    }
}
