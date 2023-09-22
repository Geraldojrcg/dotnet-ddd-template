using AutoMapper;
using DotNetDddTemplate.Application.Interfaces;
using DotNetDddTemplate.Domain.User.Entities;
using DotNetDddTemplate.Infra.Database.Models;

namespace DotNetDddTemplate.Infra.Database.Repositories;

public class RegisterUserRepository: IRegisterUserRepository
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public RegisterUserRepository(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void Execute(User user)
    {
        var model = _mapper.Map<UserModel>(user);
        _context.Users.Add(model);
        _context.SaveChanges();
    }
}