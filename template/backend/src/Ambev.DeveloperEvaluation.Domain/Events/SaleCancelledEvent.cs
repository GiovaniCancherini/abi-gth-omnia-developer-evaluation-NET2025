using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Events;

public sealed record SaleCancelledEvent(Guid SaleId) : DomainEvent;