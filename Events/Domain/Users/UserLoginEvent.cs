
using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Domain.Users
{
    public record UserLoginEvent(string AggregateId, string Name, string Ip, string Device) : IDomainEvent
    {
        public DateTime OccurredAt { get; init; } = DateTime.UtcNow;

    }
}
