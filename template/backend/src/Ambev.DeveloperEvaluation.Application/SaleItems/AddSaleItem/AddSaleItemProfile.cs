using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.SaleItems.AddSaleItem;

/// <summary>
/// Profile for mapping between SaleItem entity and AddSaleItemResponse
/// </summary>
public class AddSaleItemProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for AddSaleItem operation
    /// </summary>
    public AddSaleItemProfile()
    {
        CreateMap<AddSaleItemCommand, SaleItem>();
        CreateMap<SaleItem, AddSaleItemResult>();
    }
}
