using DotNetDddTemplate.Domain.User.Entities;

namespace DotNetDddTemplate.Application.Interfaces;

public interface IRegisterUserRepository
{
    void Execute(User user);
}