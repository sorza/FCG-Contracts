namespace FCG.Shared.Contracts.Events
{
    public record GameCreatedEvent(Guid Id, string Title, decimal Price, int LaunchYear, string Developer, string Genre);
}
