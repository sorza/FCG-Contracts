namespace FCG.Shared.Contracts.Interfaces
{
    public interface IDomainEvent
    {
        string AggregateId { get; }
        DateTime OccurredAt { get; }
    }
}
