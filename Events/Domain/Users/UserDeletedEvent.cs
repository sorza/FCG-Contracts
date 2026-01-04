using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Domain.Users
{
    public record UserDeletedEvent(string AggregateId, string Email) : IDomainEvent
    {
        public DateTime OccurredAt { get; } = DateTime.UtcNow;
    }
}
