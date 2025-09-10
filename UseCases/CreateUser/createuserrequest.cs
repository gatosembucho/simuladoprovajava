using System.ComponentModel.DataAnnotations;

namespace Simuladoprovajava.UseCases.CreateUser;

public record CreateUserRequest
{

    [Required]
    public string Username { get; init; }

    [Required]
    [EmailAddress]
    public string email { get; init; }

    [Required]
    public string Password { get; init; }

    public string Description { get; init; }
    
    
}