using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Users.GetAllUser;

/// <summary>
/// Profile for mapping between User entity and GetAllUserResponse
/// </summary>
public class GetAllUserProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetAllUser operation
    /// </summary>
    public GetAllUserProfile()
    {
        CreateMap<User, List<GetAllUserResult>>();
    }
}
