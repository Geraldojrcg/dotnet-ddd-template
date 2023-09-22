using AutoMapper;
using DotNetDddTemplate.Domain.User.Entities;
using DotNetDddTemplate.Domain.User.UseCases;
using DotNetDddTemplate.Infra.Http.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDddTemplate.Infra.Http.Controllers;

[ApiController]
[Route("users")]
public class UserController: ControllerBase
{
    private readonly IRegisterUserUseCase _registerUserService;
    private readonly IListAllUsersUseCase _listAllUsersService;
    private readonly IMapper _mapper;

    public UserController(
        IRegisterUserUseCase registerUserService, 
        IListAllUsersUseCase listAllUsersService, 
        IMapper mapper
    )
    {
        _registerUserService = registerUserService;
        _listAllUsersService = listAllUsersService;
        _mapper = mapper;
    }

    [HttpGet]
    public Task<List<User>> GetAllUsers()
    {
        return _listAllUsersService.Execute();
    }

    [HttpPost]
    public IActionResult RegisterUser(RegisterUserDto dto)
    {
        _registerUserService.Execute(_mapper.Map<User>(dto));
        return Ok(new { message = "User created" });
    }
}