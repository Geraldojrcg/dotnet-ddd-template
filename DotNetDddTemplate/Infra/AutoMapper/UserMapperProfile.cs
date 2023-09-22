using AutoMapper;
using DotNetDddTemplate.Domain.User.Entities;
using DotNetDddTemplate.Infra.Database.Models;
using DotNetDddTemplate.Infra.Http.Dtos;

namespace DotNetDddTemplate.Infra.AutoMapper;

public class UserMapperProfile: Profile
{
    public UserMapperProfile()
    {
        CreateMap<User, UserModel>();
        CreateMap<UserModel, User>();
        
        CreateMap<RegisterUserDto, User>();
    }
}