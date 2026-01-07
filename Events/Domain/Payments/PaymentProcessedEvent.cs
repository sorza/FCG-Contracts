using FCG.Shared.Contracts.Enums;
using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Domain.Payments
{
    public record PaymentProcessedEvent(string AggregateId, EPaymentType PaymentType, EPaymentStatus PaymentStatus) : IDomainEvent
    {
        public DateTime OccurredAt { get; init; } = DateTime.UtcNow;
    };
}
