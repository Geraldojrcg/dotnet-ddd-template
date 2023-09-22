namespace DotNetDddTemplate.Domain.User.UseCases;

using Entities;

public interface IRegisterUserUseCase
{
    void Execute(User user);
}