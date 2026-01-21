namespace WebCivAPI.Contracts.UsersContracts
{
    public record UserRequest(string login, string password, string email);
}
