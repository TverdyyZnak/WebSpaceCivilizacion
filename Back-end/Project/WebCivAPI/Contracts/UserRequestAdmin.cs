namespace WebCivAPI.Contracts
{
    public record UserRequestAdmin(string login, string password, string email, bool isAdmin);
}
