using AutoMapper;
using DotNetDddTemplate.Application.Interfaces;
using DotNetDddTemplate.Domain.User.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNetDddTemplate.Infra.Database.Repositories;

public class ListAllUsersRepository: IListAllUsersRepository
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public ListAllUsersRepository(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public Task<List<User>> Execute()
    {
        return _context.Users.Select(m => _mapper.Map<User>(m)).ToListAsync();
    }
}