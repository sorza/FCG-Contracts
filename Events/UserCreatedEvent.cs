namespace FCG.Shared.Contracts.Events
{
    public record UserCreatedEvent(Guid Id, string Name, string Email, string Profile, bool Active);
}
