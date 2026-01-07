using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Domain.Users
{
    public record UserCreatedEvent(string AggregateId, string Name, string Password, string Email, string Profile, bool Active) : IDomainEvent
    {
        public DateTime OccurredAt { get; init; } = DateTime.UtcNow;
    }
}
