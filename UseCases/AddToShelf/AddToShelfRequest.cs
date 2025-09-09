namespace Simuladoprovajava.UseCases.AddToShelf;

public record AddToShelfRequest
{
    public int ShelfName { get; init; }
    public int FanficID { get; init; }
}