using System.ComponentModel.DataAnnotations;

namespace Simuladoprovajava.UseCases.Login;

public record LoginRequest
{
    [Required]
    public string Email { get; init; }
    [Required]
    public string Password{ get; init; }
}