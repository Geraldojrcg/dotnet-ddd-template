using AutoMapper;
using DotNetDddTemplate.Application.Interfaces;
using DotNetDddTemplate.Application.Services;
using DotNetDddTemplate.Domain.User.UseCases;
using DotNetDddTemplate.Infra.Database;
using DotNetDddTemplate.Infra.Database.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

{
    var services = builder.Services;
 
    services.AddDbContext<DatabaseContext>();
    
    // Data layer
    services.AddScoped<IListAllUsersUseCase, ListAllUsersService>();
    services.AddScoped<IRegisterUserUseCase, RegisterUserService>();
    
    // Infra layer
    services.AddScoped<IRegisterUserRepository, RegisterUserRepository>();
    services.AddScoped<IListAllUsersRepository, ListAllUsersRepository>();
    
    // Auto Mapper
    services.AddAutoMapper(typeof(Program));
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();