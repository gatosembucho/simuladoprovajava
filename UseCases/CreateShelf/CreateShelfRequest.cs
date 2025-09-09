using System.ComponentModel.DataAnnotations;

namespace Simuladoprovajava.UseCases.CreateShelf;

public record CreateShelfRequest
{
    [Required]
    public string Title { get; init; }
    [Required]
    public int OwnerID { get; init; }
}