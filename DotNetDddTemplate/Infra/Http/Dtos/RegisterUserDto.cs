using System.ComponentModel.DataAnnotations;

namespace DotNetDddTemplate.Infra.Http.Dtos;

public class RegisterUserDto
{
    [Required]
    [MaxLength(30)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
}