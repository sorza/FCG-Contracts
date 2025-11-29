using FCG.Shared.Contracts.Enums;

namespace FCG.Shared.Contracts.Events
{
    public record LibraryItemCreatedEvent(Guid ItemId, Guid UserId, Guid GameId, EOrderStatus Status, decimal? PricePaid, EPaymentType PaymentType);
}
