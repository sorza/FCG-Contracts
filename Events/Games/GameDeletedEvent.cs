using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Games
{
    public record GameDeletedEvent(string AggregateId, string Title) : IDomainEvent
    {
        public DateTime OccurredAt { get; } = DateTime.UtcNow;
    };
}
