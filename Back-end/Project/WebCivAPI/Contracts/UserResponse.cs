namespace WebCivAPI.Contracts
{
    public record UserResponse(Guid id, string login, string password, string email, bool isAdmin);
    
}
