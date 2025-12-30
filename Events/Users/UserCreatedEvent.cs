namespace FCG.Shared.Contracts.Events.Users
{
    public record UserCreatedEvent(Guid Id, string Name, string Email, string Profile, bool Active);
}
