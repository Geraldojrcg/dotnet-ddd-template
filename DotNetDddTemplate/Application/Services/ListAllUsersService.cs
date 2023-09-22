using DotNetDddTemplate.Application.Interfaces;
using DotNetDddTemplate.Domain.User.Entities;
using DotNetDddTemplate.Domain.User.UseCases;

namespace DotNetDddTemplate.Application.Services;

public class ListAllUsersService: IListAllUsersUseCase
{
    private readonly IListAllUsersRepository _repository;

    public ListAllUsersService(IListAllUsersRepository repository)
    {
        _repository = repository;
    }

    public Task<List<User>> Execute()
    {
        return _repository.Execute();
    }
}