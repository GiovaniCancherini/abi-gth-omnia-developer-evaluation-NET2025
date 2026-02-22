using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Events;

public sealed record ItemCancelledEvent(Guid SaleId, Guid ItemId) : DomainEvent;