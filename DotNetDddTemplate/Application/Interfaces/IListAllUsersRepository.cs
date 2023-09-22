using DotNetDddTemplate.Domain.User.Entities;

namespace DotNetDddTemplate.Application.Interfaces;

public interface IListAllUsersRepository
{
    Task<List<User>> Execute();
}