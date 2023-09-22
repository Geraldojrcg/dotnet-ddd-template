using System.Text.RegularExpressions;

namespace DotNetDddTemplate.Domain.User.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }

    public User()
    {
        Id =  Guid.NewGuid();
    }

    public User(Guid? id, string name, string email)
    {
        Id = id ?? Guid.NewGuid();
        Name = ValidateName(name);
        Email = ValidateEmail(email);
    }

    private string ValidateName(string name)
    {
        return name.Length <= 30 ? name : throw new Exception("Name is too big");
    }

    private string ValidateEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase) 
            ? email 
            : throw new Exception("Invalid email");
    }

    public void ChangeName(string name)
    {
        Name = ValidateName(name);
    }
    
    public void ChangeEmail(string email)
    {
        Email = ValidateEmail(email);
    }
    
}