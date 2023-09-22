using DotNetDddTemplate.Application.Interfaces;
using DotNetDddTemplate.Domain.User.Entities;
using DotNetDddTemplate.Domain.User.UseCases;

namespace DotNetDddTemplate.Application.Services;

public class RegisterUserService: IRegisterUserUseCase
{

    private readonly IRegisterUserRepository _repository;

    public RegisterUserService(IRegisterUserRepository repository)
    {
        _repository = repository;
    }

    public void Execute(User user)
    {
        _repository.Execute(user);
    }
}