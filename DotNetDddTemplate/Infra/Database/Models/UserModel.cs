using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetDddTemplate.Infra.Database.Models;

[Table("tbl_users")]
[Index(nameof(Email), IsUnique = true)]
public class UserModel
{
    [Column("id"), Required]
    public string Id { get; set; }
    
    [Column("name"), Required]
    public string Name { get; set; }
    
    [Column("email"), Required]
    public string Email { get; set; }
}