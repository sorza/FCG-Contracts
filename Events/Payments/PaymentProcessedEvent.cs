using FCG.Shared.Contracts.Enums;

namespace FCG.Shared.Contracts.Events.Payments
{
    public record PaymentProcessedEvent(Guid PaymentId, Guid OrderId, EPaymentType PaymentType, EPaymentStatus PaymentStatus);
}
