using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Domain.Payments
{
    public record PaymentStatusChanged(string AggregateId, string PaymentType, string Status, decimal Price ) : IDomainEvent
    {       
        public DateTime OccurredAt { get; init; } = DateTime.UtcNow;
    }
}
