namespace WebCivAPI.Contracts.UsersContracts
{
    public record UserRequestAdmin(string login, string password, string email, bool isAdmin);
}
