using FCG.Shared.Contracts.Enums;

namespace FCG.Shared.Contracts
{
    public record GameCreatedEvent(Guid Id, string Title, decimal Price, int LaunchYear, string Developer, string Genre);
    public record GameUpdatedEvent(Guid Id, string Title, decimal Price, int LaunchYear, string Developer, string Genre);
    public record GameDeletedEvent(Guid Id);

    public record LibraryOrderEvent(Guid ItemId, Guid UserId, Guid GameId, EOrderStatus Status, decimal? PricePaid, EPaymentType PaymentType);
    public record LibraryItemCreatedEvent(Guid ItemId, Guid UserId, Guid GameId, EOrderStatus Status, decimal? PricePaid, EPaymentType PaymentType);

    public record UserCreatedEvent(Guid Id, string Name, string Email, string Profile, bool Active);
    public record UserDeletedEvent(Guid id);

    public record PaymentProcessedEvent(Guid PaymentId, Guid OrderId, EPaymentType PaymentType, EPaymentStatus PaymentStatus);

}
