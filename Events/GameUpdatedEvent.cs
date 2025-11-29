namespace FCG.Shared.Contracts.Events
{
    public record GameUpdatedEvent(Guid Id, string Title, decimal Price, int LaunchYear, string Developer, string Genre);
}
