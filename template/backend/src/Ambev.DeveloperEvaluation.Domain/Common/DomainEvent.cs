namespace Ambev.DeveloperEvaluation.Domain.Common;

public abstract record DomainEvent
{
    public DateTime OccurredOn { get; init; } = DateTime.UtcNow;
}