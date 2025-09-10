namespace Simuladoprovajava.UseCases.ViewShelves;

public record ViewShelvesRequest
{
    public string Title { get; init; }

    public int OwnerID { get; init; }
}