namespace DotNetDddTemplate.Domain.User.UseCases;

using Entities;

public interface IListAllUsersUseCase
{
    Task<List<User>> Execute();
}