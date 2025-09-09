namespace Simuladoprovajava.UseCases.ViewFanfiction;

public record ViewFanfictionIRequest{
    public string Title { get; init; }
    public DateTime Release { get; init; }
    public string Text { get; init; }
    public int AuthorID{ get; init; }
}