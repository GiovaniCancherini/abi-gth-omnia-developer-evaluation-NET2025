using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.SaleItems.GetByIdSale;

/// <summary>
/// Handler for processing GetByIdSaleIdCommand requests
/// </summary>
public class GetByIdSaleHandler : IRequestHandler<GetByIdSaleQuery, GetByIdSaleResult>
{
    private readonly ISaleItemRepository _saleItemRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetByIdSaleHandler
    /// </summary>
    /// <param name="saleItemRepository">The sale repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for GetByIdSaleIdCommand</param>
    public GetByIdSaleHandler(
        ISaleItemRepository saleItemRepository,
        IMapper mapper)
    {
        _saleItemRepository = saleItemRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the GetByIdSaleIdCommand request
    /// </summary>
    /// <param name="request">The GetByIdSaleId command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The sale item details if found</returns>
    public async Task<GetByIdSaleResult> Handle(GetByIdSaleQuery request, CancellationToken cancellationToken)
    {
        var validator = new GetByIdSaleValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var saleItem = await _saleItemRepository.GetAllByIdSaleAsync(request.SaleId, cancellationToken);
        if (saleItem == null)
        {
            throw new KeyNotFoundException($"SaleItem with ID Sale {request.SaleId} not found");
        }

        return _mapper.Map<GetByIdSaleResult>(saleItem);
    }
}
