using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Domain.Payments
{
    public record PaymentDeletedEvent(string AggregateId) : IDomainEvent
    {
        public DateTime OccurredAt { get; } = DateTime.UtcNow;
    }
}
