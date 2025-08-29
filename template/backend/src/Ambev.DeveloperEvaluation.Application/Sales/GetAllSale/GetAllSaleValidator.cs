using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetAllSale;

/// <summary>
/// Validator for GetAllSaleCommand
/// </summary>
public class GetAllSaleValidator : AbstractValidator<GetAllSaleQuery>
{
    /// <summary>
    /// Initializes validation rules for GetAllSaleCommand
    /// </summary>
    public GetAllSaleValidator()
    {
    }
}
