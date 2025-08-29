using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetAllSale;

/// <summary>
/// Response model for the GetAllSale operation.
/// </summary>
public class GetAllSaleResult
{
    /// <summary>
    /// Gets or sets the list of sales retrieved from the operation.
    /// </summary>
    public List<Sale> Data { get; set; } = new List<Sale>();
}