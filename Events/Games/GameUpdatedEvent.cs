using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Games
{
    public record GameUpdatedEvent(string AggregateId, string Title, decimal Price, int LaunchYear, string Developer, string Genre) : IDomainEvent
    {       
        public DateTime OccurredAt { get; } = DateTime.UtcNow;
    };
}
