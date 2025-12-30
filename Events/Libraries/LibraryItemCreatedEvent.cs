using FCG.Shared.Contracts.Enums;
using FCG.Shared.Contracts.Interfaces;

namespace FCG.Shared.Contracts.Events.Libraries
{
    public record LibraryItemCreatedEvent(Guid ItemId, Guid UserId, Guid GameId, EOrderStatus Status, decimal? PricePaid, EPaymentType PaymentType);
}
