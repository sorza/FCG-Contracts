using FCG.Shared.Contracts.Enums;
using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Domain.Libraries
{
    public record LibraryItemCreatedEvent(string AggregateId, Guid UserId, Guid GameId, EOrderStatus Status, decimal? PricePaid) : IDomainEvent
    {
        public DateTime OccurredAt { get; init; } = DateTime.UtcNow;
    };
}
