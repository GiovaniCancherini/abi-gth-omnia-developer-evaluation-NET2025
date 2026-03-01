using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.SaleItems.GetBySaleItemId;

/// <summary>
/// Response model for GetBySaleItemId operation
/// </summary>
public class GetBySaleItemIdResult
{
    /// <summary>
    /// The unique identifier of the sale
    /// </summary>
    public Guid Id { get; set; }

}
