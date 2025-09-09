using System.ComponentModel.DataAnnotations;
using SimuladoProvaJava.Validations;
namespace Simuladoprovajava.UseCases.WriteFanfiction;

public record WriteFanfictionRequest
{
    [Required]
    public string Title { get; init; }


    [MaxLines]
    [MaxWords]
    [Required]
    [MaxLength(6000)]
    public string Text { get; init; }
    
    public int AuthorID { get; init; }
}