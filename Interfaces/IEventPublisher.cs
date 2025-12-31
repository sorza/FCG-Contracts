namespace FCG.Shared.Contracts.Interfaces
{
    public interface IEventPublisher
    {
        public Task PublishAsync<T>(T evt, string subject, string correlationId);
    }
}
