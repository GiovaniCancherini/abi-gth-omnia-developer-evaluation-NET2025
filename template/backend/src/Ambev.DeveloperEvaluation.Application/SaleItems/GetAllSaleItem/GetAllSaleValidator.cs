using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.SaleItems.GetAllSaleItem;

/// <summary>
/// Validator for GetAllSaleItemCommand
/// </summary>
public class GetAllSaleItemValidator : AbstractValidator<GetAllSaleItemQuery>
{
    /// <summary>
    /// Initializes validation rules for GetAllSaleItemCommand
    /// </summary>
    public GetAllSaleItemValidator()
    {
    }
}
