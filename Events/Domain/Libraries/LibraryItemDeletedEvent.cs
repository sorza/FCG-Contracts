using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Domain.Libraries
{
    public record LibraryItemDeletedEvent(string AggregateId, Guid UserId, Guid GameId) : IDomainEvent
    {
        public DateTime OccurredAt { get; } = DateTime.UtcNow;
    }
}
