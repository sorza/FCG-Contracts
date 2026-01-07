using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Domain.Games
{
    public record GameCreatedEvent(string AggregateId, string Title, decimal Price, int LaunchYear, string Developer, string Genre): IDomainEvent
    {
        public DateTime OccurredAt { get; } = DateTime.UtcNow;
    };
}
