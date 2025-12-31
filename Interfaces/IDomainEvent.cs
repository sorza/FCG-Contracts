namespace FCG.Shared.Contracts.Interfaces
{
    public interface IDomainEvent
    {
        public string AggregateId { get; }
        public DateTime OccurredAt { get; }
    }
}
