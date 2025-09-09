using System.ComponentModel.DataAnnotations;

namespace Simuladoprovajava.UseCases.WriteFanfiction;

public record WriteFanfictionRequest
{
    [Required]
    public string Title { get; init; }

    [Required]
    public string Text { get; init; }
    
    public int AuthorID { get; init; }
}