using FCG.Shared.Contracts.Enums;

namespace FCG.Shared.Contracts.Events
{
    public record PaymentProcessedEvent(Guid PaymentId, Guid OrderId, EPaymentType PaymentType, EPaymentStatus PaymentStatus);
}
