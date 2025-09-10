namespace Simuladoprovajava.UseCases.AddToShelf;

public record AddToShelfRequest
{
    public string ShelfName { get; init; }
    public int FanficID { get; init; }
}