using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.ListUsers;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings
{
    public class ListUsersProfile : Profile
    {
        public ListUsersProfile()
        {
            CreateMap<User, ListUsersResponse>();
        }
    }
}
