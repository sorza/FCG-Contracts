using FCG.Shared.Contracts.Enums;
using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Domain.Payments
{
    public record PaymentCreatedEvent(string AggregateId, List<Guid> LibraryItens, EPaymentType PaymentType, EPaymentStatus Status, decimal Price) : IDomainEvent
    {
        public DateTime OccurredAt { get; init; } = DateTime.UtcNow;
    };
}
