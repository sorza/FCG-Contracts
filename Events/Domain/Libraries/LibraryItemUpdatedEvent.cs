using FCG.Shared.Contracts.Enums;
using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Domain.Libraries
{
    public record LibraryItemUpdatedEvent(string AggregateId, EOrderStatus status) : IDomainEvent
    {
        public DateTime OccurredAt { get; init; } = DateTime.UtcNow;
    }
}
