using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetAllSale;

/// <summary>
/// Profile for mapping between User entity and GetAllSaleResult
/// </summary>
public class GetAllSaleProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetAllSale operation
    /// </summary>
    public GetAllSaleProfile()
    {
        CreateMap<Sale, GetAllSaleResult>();
    }
}
